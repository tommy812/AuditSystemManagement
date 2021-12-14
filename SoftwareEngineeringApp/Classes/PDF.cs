using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace SoftwareEngineeringApp.Classes
{
    class PDF
    {
		public void GetHeader(int id)
        {
			//Retrive report infromation using the report id 
			DBConnection dbConn = DBConnection.getInstanceOfDBConnection();
			DataTable hdt = dbConn.GetData2("Select a.Audit_ID, a.Date, a.Completed_By, s.Site_Name, w.Area, u.Name, u.Name, t.type, " +
				"te.template_name, i.Interventions From audit_info a inner join Sites s on a.Site_ID = s.Site_ID inner join work_area w on " +
				"a.Area_ID = w.Work_area_ID inner join users u on a.Supervisor_ID = u.User_ID and a.Inspector_ID = u.User_ID inner join" +
				" Inspection_type t on a.Type_ID = t.type_ID inner join Template te on a.template_ID = te.template_ID inner join" +
				" audit_Overall_result i on a.audit_ID = i.audit_ID");
			
			string query = ("SELECT q.question, a.Interventions, a.Completed, a.Action_Taken, a.Comment FROM audit a inner join Questions q" +
				" on q.question_ID = a.question_ID WHERE a.audit_ID=@audit_ID");
			DataTable dt = dbConn.GetValueByID(query,id, "audit_ID");

			query = ("Select c.Category, a.interventions from Audit_category_results a inner join Categories c on c.category_ID = a.category_ID " +
				" WHERE a.audit_ID=@audit_ID");
			DataTable Cinterventions = dbConn.GetValueByID(query, id, "audit_ID");


			// method to generate pdf 
			ExportToPdf(id, dt, hdt, Cinterventions);


        }

		//Teplate Design Resource: https://youtu.be/JBSt2L_faD8
		private void ExportToPdf(int audit_ID, DataTable dt, DataTable hdt, DataTable interventions)
		{ // create pdf 
			try
			{
				var pdfDoc = new Document(PageSize.A4, 40f, 40f, 60f, 60f);
				
				string name = audit_ID.ToString() + ".pdf";
				string outputFile = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+name;
				string dir = (Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/reports/");
				// If directory does not exist, create it
				if (!Directory.Exists(dir))
				{
					Directory.CreateDirectory(dir);
				}
				string path = dir + name;
				PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
				pdfDoc.Open();
				var imagepath = Directory.GetCurrentDirectory() + "\\Logo.jpg";

				//var imagepath = "C:/Users/thoma/Source/Repos/SoftwareEngineeringApp7/SoftwareEngineeringApp/Logo.jpg";
				using (FileStream fs = new FileStream(imagepath, FileMode.Open))
				{
					var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
					png.ScalePercent(50f);
					png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
					pdfDoc.Add(png);
				}

				var spacer = new Paragraph("")
				{
					SpacingBefore = 10f,
					SpacingAfter = 10f,
				};
				pdfDoc.Add(spacer);

				var headerTable = new PdfPTable(new[] { .75f, 2f })
				{
					//HorizontalAlignment = Left,
					WidthPercentage = 75,
					DefaultCell = { MinimumHeight = 22f }
				};

				headerTable.AddCell("Audit ID");
				headerTable.AddCell(hdt.Rows[0][0].ToString());
				headerTable.AddCell("Date");
				headerTable.AddCell(hdt.Rows[0][1].ToString());
				headerTable.AddCell("Completed_by");
				headerTable.AddCell(hdt.Rows[0][2].ToString());
				headerTable.AddCell("Site");
				headerTable.AddCell(hdt.Rows[0][3].ToString());
				headerTable.AddCell("Area");
				headerTable.AddCell(hdt.Rows[0][4].ToString());
				headerTable.AddCell("Supervisor");
				headerTable.AddCell(hdt.Rows[0][5].ToString());
				headerTable.AddCell("Inspector");
				headerTable.AddCell(hdt.Rows[0][6].ToString());
				headerTable.AddCell("type");
				headerTable.AddCell(hdt.Rows[0][7].ToString());
				headerTable.AddCell("PDf Generated on");
				headerTable.AddCell(DateTime.Now.ToString());

				pdfDoc.Add(headerTable);
				pdfDoc.Add(spacer);



				var columnCount = dt.Columns.Count;
				var columnWidths = new[] { 2f, 1.3f, 1f, 2f, 2f };

				var table = new PdfPTable(columnWidths)
				{
					HorizontalAlignment = 0,
					WidthPercentage = 100,
					DefaultCell = { MinimumHeight = 44f }
				};

				var cell = new PdfPCell(new Phrase("Report"))
				{
					Colspan = columnCount,
					HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
					MinimumHeight = 44f
				};

				table.AddCell(cell);

				dt.Columns
					.OfType<DataColumn>()
					.ToList()
					.ForEach(c => table.AddCell(c.ColumnName));

				for (int i = 0; i < dt.Rows.Count; i++)
				{
					for (int j = 0; j < dt.Columns.Count; j++)
					{
						cell = new PdfPCell(new Phrase(dt.Rows[i][j].ToString()));

						//Align the cell in the center
						cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
						cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

						table.AddCell(cell);
					}
				}

				pdfDoc.Add(table);
				pdfDoc.Add(spacer);

				var ResultsTable = new PdfPTable(new[] { .75f, 2f })
				{
					HorizontalAlignment = 0,
					WidthPercentage = 75,
					DefaultCell = { MinimumHeight = 44f }
				};

			     cell = new PdfPCell(new Phrase("Results"))
				{
					Colspan = columnCount,
					HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
					MinimumHeight = 30f
				};

				ResultsTable.AddCell(cell);
				for (int i = 0; i < interventions.Rows.Count; i++)
				{
					for (int j = 0; j < interventions.Columns.Count; j++)
					{
						cell = new PdfPCell(new Phrase(interventions.Rows[i][j].ToString()));

						//Align the cell in the center
						cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
						cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

						ResultsTable.AddCell(cell);
					}
				}
		

				pdfDoc.Add(ResultsTable);


				pdfDoc.Close();
				MessageBox.Show("report saved successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error saving report" + "/n"+ ex.ToString());
			}
		}

		public void exportListPdf(String UserName, Chart chart,DataTable dt, String num )
        {
			try
			{
				var pdfDoc = new Document(PageSize.A4, 40f, 40f, 60f, 60f);

				string dir = (Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/reports/reportsList/");
				// If directory does not exist, create it
				if (!Directory.Exists(dir))
				{
					Directory.CreateDirectory(dir);
				}
				string[] file = Directory.GetFiles(dir).Select(filename => Path.GetFileNameWithoutExtension(filename)).ToArray();
				int size = file.Length;
				size++;
				string name = "ReportList"+ size+".pdf";
				string path = dir + name;
				
				PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
				pdfDoc.Open();

				var imagepath = "C:/Users/thoma/Source/Repos/SoftwareEngineeringApp7/SoftwareEngineeringApp/Logo.jpg";
				string fileName = "Logo.jpg";
				string paths = Path.Combine(Environment.CurrentDirectory, @"", fileName);
				using (FileStream fs = new FileStream(paths, FileMode.Open))
				{
					var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
					png.ScalePercent(50f);
					png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
					pdfDoc.Add(png);
				}

				var spacer = new Paragraph("")
				{
					SpacingBefore = 10f,
					SpacingAfter = 10f,
				};
				pdfDoc.Add(spacer);

				var columnCount = dt.Columns.Count;
				var columnWidths = new[] { 2f, 2f, 2f, 2.5f, 1.5f, 2f,2f,2f,2f,2f };

				var table = new PdfPTable(columnWidths)
				{
					HorizontalAlignment = 0,
					WidthPercentage = 100,
					DefaultCell = { MinimumHeight = 44f }
				};

				var cell = new PdfPCell(new Phrase("list of last "+num+" Report"))
				{
					Colspan = columnCount,
					HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
					MinimumHeight = 44f
				};

				table.AddCell(cell);

				dt.Columns
					.OfType<DataColumn>()
					.ToList()
					.ForEach(c => table.AddCell(c.ColumnName));

				for (int i = 0; i < dt.Rows.Count; i++)
				{
					for (int j = 0; j < dt.Columns.Count; j++)
					{
						cell = new PdfPCell(new Phrase(dt.Rows[i][j].ToString()));

						//Align the cell in the center
						cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
						cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

						table.AddCell(cell);
					}
				}

				pdfDoc.Add(table);
				pdfDoc.Add(spacer);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					chart.SaveImage(memoryStream, ChartImageFormat.Png);
					iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
					img.ScalePercent(75f);
					pdfDoc.Add(img);
				}
				pdfDoc.Close();
				MessageBox.Show("report saved successfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show("error saving report" + "/n" + ex.ToString());
			}
		}
	}
}
