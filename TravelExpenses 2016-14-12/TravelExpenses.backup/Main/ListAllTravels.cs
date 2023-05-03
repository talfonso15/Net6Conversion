﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;


namespace TravelExpenses
{
    public partial class ListAllTravels : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        Guid travelID;
        Guid userID;
        double travelACC = 0;
        double trainingACC = 0;
        int canT = 0;
        int index = 0;
        public ListAllTravels()
        {
            InitializeComponent();
        }

        private void ListAllTravels_Load(object sender, EventArgs e)
        {
            userID = new Guid(CommonVariables.user);
            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID where a.UserID = '" + userID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string travelID = dr["TravelID"].ToString();
                string depDate = Convert.ToDateTime(dr["DepartureDate"].ToString()).ToShortDateString();
                string retDate = Convert.ToDateTime(dr["ReturnDate"].ToString()).ToShortDateString();
                string travEvent = dr["TravelEvent"].ToString();
                string travPurpose = dr["TravelPurpose"].ToString();
                string origin = dr["Origin"].ToString();
                string destination = dr["Destination"].ToString();
                string travTotal = dr["TotalTravelAmount"].ToString();
                string status = dr["Status"].ToString();

                dgvAllTravels.Rows.Add(depDate, retDate, travEvent, travPurpose, origin, destination, status, travTotal, travelID);
            }
            dr.Close();

            for (int i = 0; i < dgvAllTravels.RowCount; i++)
            {
                Guid idTravApp = new Guid(dgvAllTravels.Rows[i].Cells[8].Value.ToString());
                SqlCommand approved = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '"+ idTravApp + "' AND UserType = 'Employee'", localCon);
                SqlDataReader approvedDR = approved.ExecuteReader();
                if (approvedDR.HasRows)
                {
                    dgvAllTravels.Rows[i].Cells[9].Value = "Yes";
                }
                else
                {
                    dgvAllTravels.Rows[i].Cells[9].Value = "No";
                }
                approvedDR.Close();
            }

            localCon.Close();
            canT = dgvAllTravels.RowCount;
        }

        private void btnFinalTravel_Click(object sender, EventArgs e)
        {
            if (canT > 0)
            {
                DialogResult fin = MessageBox.Show("If you make your travel final it will be no longer available for editing, making your travel final means that you are archiving or canceling it. Do you still want to finalize your travel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (fin == DialogResult.Yes)
                {
                    int rowIndex = dgvAllTravels.CurrentRow.Index;
                    string travID = dgvAllTravels.Rows[rowIndex].Cells[8].Value.ToString();
                    string status = dgvAllTravels.Rows[rowIndex].Cells[6].Value.ToString();
                    travelID = new Guid(travID);

                    if (status == "Pending")
                    {
                        localCon.Open();
                        SqlDataAdapter upStatus = new SqlDataAdapter();
                        upStatus.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[TravelStatus] SET [Status] = @Status WHERE TravelID = '" + travelID + "'", localCon);
                        upStatus.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Final";
                        int ru = upStatus.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("The travel status has been changed to final successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshTravels();
                        }

                    }
                    else
                    {
                        MessageBox.Show("This travel is final already", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  }
                }
                else
                {
                    MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void refreshTravels()
        {
            dgvAllTravels.Rows.Clear();
            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID where a.UserID = '" + userID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string travelID = dr["TravelID"].ToString();
                string depDate = Convert.ToDateTime(dr["DepartureDate"].ToString()).ToShortDateString();
                string retDate = Convert.ToDateTime(dr["ReturnDate"].ToString()).ToShortDateString();
                string travEvent = dr["TravelEvent"].ToString();
                string travPurpose = dr["TravelPurpose"].ToString();
                string origin = dr["Origin"].ToString();
                string destination = dr["Destination"].ToString();
                string travTotal = dr["TotalTravelAmount"].ToString();
                string status = dr["Status"].ToString();
                dgvAllTravels.Rows.Add(depDate, retDate, travEvent, travPurpose, origin, destination, status, travTotal, travelID);
            }
            dr.Close();

            for (int i = 0; i < dgvAllTravels.RowCount; i++)
            {
                Guid idTravApp = new Guid(dgvAllTravels.Rows[i].Cells[8].Value.ToString());
                SqlCommand approved = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '" + idTravApp + "' AND UserType = 'Employee'", localCon);
                SqlDataReader approvedDR = approved.ExecuteReader();
                if (approvedDR.HasRows)
                {
                    dgvAllTravels.Rows[i].Cells[9].Value = "Yes";
                }
                else
                {
                    dgvAllTravels.Rows[i].Cells[9].Value = "No";
                }
                approvedDR.Close();
            }

            localCon.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonVariables.filePath = "";
            this.Close();
        }

        private void btnGenerateDetailPDF_Click(object sender, EventArgs e)
        {
            if (canT > 0)
            {
                localCon.Open();
                string name = "";
                string lastname = "";
                string district = "";
                string department = "";
                string fullName = "";
                int rowIndex = dgvAllTravels.CurrentRow.Index;
                string IdTrav = dgvAllTravels.Rows[rowIndex].Cells[8].Value.ToString();
                Guid travID = new Guid(IdTrav);
                string username = "";
                string departureDate = "";
                string returnDate = "";

                SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
                SqlDataReader drUser = cmdUser.ExecuteReader();
                while (drUser.Read())
                {
                    name = drUser["Name"].ToString();
                    lastname = drUser["LastName"].ToString();
                    district = drUser["District"].ToString();
                    department = drUser["Department"].ToString();
                    username = drUser["Username"].ToString();
                }
                drUser.Close();
                fullName = name + " " + lastname;

                SqlCommand cmdTDates = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drTDates = cmdTDates.ExecuteReader();
                while (drTDates.Read())
                {
                    departureDate = Convert.ToDateTime(drTDates["DepartureDate"].ToString()).ToShortDateString();
                    returnDate = Convert.ToDateTime(drTDates["ReturnDate"].ToString()).ToShortDateString();
                }
                drTDates.Close();

                string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Details).pdf";
                string pdfName = username + "_" + departureDate + "_" + "to" + "_" + returnDate + ".pdf";
                pdfName = pdfName.Replace("/", "-");
                string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form(Details)_" + pdfName;
                CommonVariables.filePath = newFile;

                PdfReader pdfReader = new PdfReader(pdfTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;



                //user details
                pdfFormFields.SetField("Full Name", fullName);
                pdfFormFields.SetField("District", district);
                pdfFormFields.SetField("Department", department);

                //travel details
                SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drTD = cmdTD.ExecuteReader();
                while (drTD.Read())
                {
                    pdfFormFields.SetField("Travel Event", drTD["TravelEvent"].ToString());
                    pdfFormFields.SetField("Travel Purpose", drTD["TravelPurpose"].ToString());
                    DateTime dd = Convert.ToDateTime(drTD["DepartureDate"].ToString());
                    pdfFormFields.SetField("Departure_Date", dd.ToShortDateString());
                    pdfFormFields.SetField("Departure_Time", drTD["DepartureTime"].ToString());
                    DateTime rd = Convert.ToDateTime(drTD["ReturnDate"].ToString());
                    pdfFormFields.SetField("Return_Date", rd.ToShortDateString());
                    pdfFormFields.SetField("Return_Time", drTD["ReturnTime"].ToString());
                    pdfFormFields.SetField("Origin", drTD["Origin"].ToString());
                    pdfFormFields.SetField("Destination", drTD["Destination"].ToString());
                    pdfFormFields.SetField("Travel State", drTD["TravelState"].ToString());
                    pdfFormFields.SetField("Travel Notes", drTD["Notes"].ToString());

                    //Tratel Totals
                    string travelCost = Convert.ToDouble(drTD["TotalTravelAmount"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    string reimb = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    string noReim = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);

                    pdfFormFields.SetField("Travel Total Cost", travelCost);
                    pdfFormFields.SetField("Reimbursement", reimb);
                    pdfFormFields.SetField("No Reimbursed", noReim);
                    pdfFormFields.SetField("Date", DateTime.Today.ToShortDateString());

                    //set up the travel common variables
                    if (drTD["Melas"].ToString() == "True")
                    {
                        CommonVariables.isMeals = true;
                    }
                    if (drTD["Registration"].ToString() == "True")
                    {
                        CommonVariables.isRegistartion = true;

                    }
                    if (drTD["CarRental"].ToString() == "True")
                    {
                        CommonVariables.isCarRental = true;
                    }
                    if (drTD["Lodging"].ToString() == "True")
                    {
                        CommonVariables.isLodging = true;
                    }
                    if (drTD["AirFare"].ToString() == "True")
                    {
                        CommonVariables.isAirFare = true;
                    }
                    if (drTD["Mileage"].ToString() == "True")
                    {
                        CommonVariables.isMileage = true;
                    }
                    if (drTD["OtherExpenses"].ToString() == "True")
                    {
                        CommonVariables.isOtherExpenses = true;
                    }


                }
                drTD.Close();

                //Meals Details
                if (CommonVariables.isMeals)
                {

                    SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader drMeals = cmdMeals.ExecuteReader();

                    while (drMeals.Read())
                    {
                        pdfFormFields.SetField("BreakfastQuantity", drMeals["Breakfast"].ToString());
                        pdfFormFields.SetField("LunchQuantity", drMeals["Lunch"].ToString());
                        pdfFormFields.SetField("DinnerQuantity", drMeals["Dinner"].ToString());
                        int brekCost = Convert.ToInt32(drMeals["Breakfast"].ToString()) * 8;
                        pdfFormFields.SetField("BreakfastCost", brekCost.ToString());
                        int lunchCost = Convert.ToInt32(drMeals["Lunch"].ToString()) * 12;
                        pdfFormFields.SetField("LunchCost", lunchCost.ToString());
                        int dinCost = Convert.ToInt32(drMeals["Dinner"].ToString()) * 20;
                        pdfFormFields.SetField("DinnerCost", dinCost.ToString());
                        if (drMeals["ProvidedMeal"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Provided Meals", "Yes");
                        }
                        else
                        {
                            pdfFormFields.SetField("Provided Meals", "No");
                        }
                        string mealcost = Convert.ToDouble(drMeals["TotalMeals"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                        pdfFormFields.SetField("Meals_Total", mealcost);
                    }
                    drMeals.Close();

                }

                //Registration Details
                if (CommonVariables.isRegistartion)
                {

                    SqlCommand cmdRegis = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader drRegis = cmdRegis.ExecuteReader();
                    while (drRegis.Read())
                    {
                        string regCost = Convert.ToDouble(drRegis["RegistrationAMount"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                        pdfFormFields.SetField("Registration Cost", regCost);

                    }
                    drRegis.Close();

                }

                //Lodging
                if (CommonVariables.isLodging)
                {

                    SqlCommand cmdLod = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader drLod = cmdLod.ExecuteReader();

                    int row = 1;
                    double totalLod = 0;
                    while (drLod.Read())
                    {
                        pdfFormFields.SetField("Facility Name" + row, drLod["FacilityName"].ToString());
                        pdfFormFields.SetField("Facility Total Cost" + row, drLod["TotalLodging"].ToString());
                        totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                        pdfFormFields.SetField("Lodging Nights" + row, drLod["NumberOfNights"].ToString());
                        pdfFormFields.SetField("Lodging Night Cost" + row, drLod["CostPerNight"].ToString());
                        pdfFormFields.SetField("Lodging Taxes Fees" + row, drLod["TaxesAndFees"].ToString());
                        if (drLod["DistrictPay"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Lodging District Pay" + row, "Yes");
                            pdfFormFields.SetField("Lodging Director Approval" + row, "");
                        }
                        else
                        {
                            pdfFormFields.SetField("Lodging District Pay" + row, "No");
                            if (drLod["DirectorApproved"].ToString() == "True")
                            {
                                pdfFormFields.SetField("Lodging Director Approval" + row, "Yes");
                            }
                            else
                            {
                                pdfFormFields.SetField("Lodging Director Approval" + row, "No");
                            }
                        }
                        pdfFormFields.SetField("Facility  Notes" + row, drLod["Notes"].ToString());
                        row++;
                    }
                    drLod.Close();
                    string logCost = totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Lodging Total", logCost);
                }

                //Car Rental Details
                if (CommonVariables.isCarRental)
                {
                    SqlCommand cmdCR = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader drCR = cmdCR.ExecuteReader();

                    int carRow = 1;
                    double totalCR = 0;

                    while (drCR.Read())
                    {

                        pdfFormFields.SetField("Pick up Date" + carRow, Convert.ToDateTime(drCR["PickUPDate"].ToString()).ToShortDateString());
                        pdfFormFields.SetField("Drop off Date" + carRow, Convert.ToDateTime(drCR["DropOffDate"].ToString()).ToShortDateString());
                        pdfFormFields.SetField("Car_Day Cost" + carRow, drCR["CostPerDay"].ToString());
                        pdfFormFields.SetField("Car Total" + carRow, drCR["TotalCarRental"].ToString());
                        totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                        pdfFormFields.SetField("Car Type" + carRow, drCR["CarType"].ToString());
                        pdfFormFields.SetField("Rental Company" + carRow, drCR["Company"].ToString());
                        pdfFormFields.SetField("Car Rental Days" + carRow, drCR["Days"].ToString());
                        pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, drCR["TaxesAndFees"].ToString());
                        pdfFormFields.SetField("LDW Insurance" + carRow, drCR["LDWInsuranse"].ToString());
                        pdfFormFields.SetField("Supplemental Insurance" + carRow, drCR["SupplementalInsurance"].ToString());
                        pdfFormFields.SetField("Extra Insurance" + carRow, drCR["ExtarInsuranceAmount"].ToString());
                        if (drCR["DistrictPay"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Car District Pay" + carRow, "Yes");
                        }
                        else
                        {
                            pdfFormFields.SetField("Car District Pay" + carRow, "No");
                        }
                        pdfFormFields.SetField("Car Personal Amount" + carRow, drCR["PersonalAmount"].ToString());
                        pdfFormFields.SetField("Car Notes" + carRow, drCR["Notes"].ToString());

                        carRow++;
                    }
                    drCR.Close();
                    string carCost = totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Car Rental Total", carCost);
                }

                //AirFare Details
                if (CommonVariables.isAirFare)
                {
                    SqlCommand cmdAF = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader drAF = cmdAF.ExecuteReader();

                    int flightRow = 1;
                    double totalAF = 0;

                    while (drAF.Read())
                    {
                        pdfFormFields.SetField("Flight_Departure Date" + flightRow, Convert.ToDateTime(drAF["DepartureDate"].ToString()).ToShortDateString());
                        if (drAF["ReturnDate"].ToString() != "")
                        {
                            DateTime rd = Convert.ToDateTime(drAF["ReturnDate"].ToString());
                            pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString());
                        }
                        pdfFormFields.SetField("Flight Total" + flightRow, drAF["AirFareTotal"].ToString());
                        totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                        pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, drAF["TaxesAndFees"].ToString());
                        if (drAF["DistrictPay"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes");
                        }
                        else
                        {
                            pdfFormFields.SetField("Flight District Pay" + flightRow, "No");
                        }
                        pdfFormFields.SetField("Flight Personal Amount" + flightRow, drAF["PersonalUseAmount"].ToString());
                        pdfFormFields.SetField("Air Fare Notes" + flightRow, drAF["Notes"].ToString());

                        flightRow++;
                    }
                    drAF.Close();
                    string flightCost = totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Air Fare Total", flightCost);
                }

                //Mileage Details
                if (CommonVariables.isMileage)
                {
                    SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader drMi = cmdMi.ExecuteReader();

                    while (drMi.Read())
                    {
                        pdfFormFields.SetField("Map Mileage", drMi["MapMileage"].ToString());
                        pdfFormFields.SetField("Vicinity Mileage", drMi["VicinityMileage"].ToString());
                        string milCost = Convert.ToDouble(drMi["TotalMileage"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                        pdfFormFields.SetField("Mileage Cost", milCost);
                        if (drMi["DistrictVehicleProvided"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Provided Vehicle", "Yes");
                        }
                        else
                        {
                            pdfFormFields.SetField("Provided Vehicle", "No");
                            if (drMi["DirectorApprovedPersonal"].ToString() == "True")
                            {
                                pdfFormFields.SetField("Mileage Director Approval", "Yes");
                            }
                            else
                            {
                                pdfFormFields.SetField("Mileage Director Approval", "No");
                            }
                        }
                        pdfFormFields.SetField("Mileage Notes", drMi["Notes"].ToString());
                    }
                    drMi.Close();
                }

                //Other Expenses
                if (CommonVariables.isOtherExpenses)
                {
                    SqlCommand cmdOE = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader drOE = cmdOE.ExecuteReader();

                    int oxRow = 1;
                    double totalOE = 0;
                    while (drOE.Read())
                    {
                        pdfFormFields.SetField("ExpDescription" + oxRow, drOE["Description"].ToString());
                        pdfFormFields.SetField("ExpCost" + oxRow, drOE["Amount"].ToString());
                        totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                        pdfFormFields.SetField("ExpNotes" + oxRow, drOE["Notes"].ToString());
                        oxRow++;
                    }
                    string oeCost = totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Other Expenses Total", oeCost);
                }



                pdfStamper.Close();
                localCon.Close();


                ViewPDF vpdf = new ViewPDF();
                vpdf.Show();
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSummarizedPDF_Click(object sender, EventArgs e)
        {
            if (canT > 0)
            {
                generatePDF();
                ViewPDF vpdf = new ViewPDF();
                vpdf.Show();
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (canT > 0)
            {
               

                    localCon.Open();

                    int rowIndex = dgvAllTravels.CurrentRow.Index;
                    string travIDValue = dgvAllTravels.Rows[rowIndex].Cells[8].Value.ToString();
                    Guid travID = new Guid(travIDValue);
                    bool isApproved = false;
                    Guid userID = new Guid(CommonVariables.user);


                    SqlCommand cmd = new SqlCommand("SELECT [TravelID],[UserID],[UserType],[TravelType] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '" + travID + "'  AND UserType = 'Employee' AND TravelType = 'Travel'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        isApproved = true;
                        MessageBox.Show("This travel was already approved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dr.Close();

                    if (!isApproved)
                    {
                        DialogResult appTravel = MessageBox.Show("Do you really want approve this Travel Expense Report?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (appTravel == DialogResult.Yes)
                        {
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelSignatures] ([TravelID],[UserID],[UserType],[TravelType],[SignatureDate]) VALUES (@TravelID,@UserID,@UserType,@TravelType,@SignatureDate)", localCon);
                            da.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travID;
                            da.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                            da.InsertCommand.Parameters.Add("@UserType", SqlDbType.VarChar).Value = "Employee";
                            da.InsertCommand.Parameters.Add("@TravelType", SqlDbType.VarChar).Value = "Travel";
                            da.InsertCommand.Parameters.Add("@SignatureDate", SqlDbType.DateTime).Value = DateTime.Today;
                            int row = da.InsertCommand.ExecuteNonQuery();
                            if (row > 0)
                            {
                                pictureBox1.Visible = true;
                                lblSendingEmail.Visible = true;
                                tableLayoutPanel1.Enabled = false;
                                dgvAllTravels.Enabled = false;
                                localCon.Close();
                                MessageBox.Show("This travel has been successfully approved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (backgroundWorker1.IsBusy != true)
                                {
                                    backgroundWorker1.RunWorkerAsync();
                                }
                            }
                        }
                }

           localCon.Close();

              
                
                
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (canT > 0)
            {
                this.Hide();
                int rowIndex = dgvAllTravels.CurrentRow.Index;
                string travID = dgvAllTravels.Rows[rowIndex].Cells[8].Value.ToString();
                string userID = CommonVariables.user;
                CommonVariables.viewTravelID = travID;
                CommonVariables.viewTravelUserID = userID;

                ViewTravel vt = new ViewTravel();
                vt.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSendEmailAccounting_Click(object sender, EventArgs e)
        {
            if (canT > 0)
            {
                index = dgvAllTravels.CurrentRow.Index;
                SupervisorList sl = new SupervisorList();
                sl.ShowDialog();
                lblSendingEmail.Visible = true;
                pictureBox1.Visible = true;
                tableLayoutPanel1.Enabled = false;
                dgvAllTravels.Enabled = false;
                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListAllTravels_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.supervisorEmail = "";
        }

        private void sendEMail()
        {
           
                localCon.Open();
                Guid userID = new Guid(CommonVariables.user);
                string email = "";
                //string supEmail = "";
                string fullname = "";
                string department = "";
                int rowIndex = index;
                Guid travID = new Guid(dgvAllTravels.Rows[rowIndex].Cells[8].Value.ToString());
                //user
                SqlCommand user = new SqlCommand("SELECT b.Email as Email, a.Name as Name, a.LastName as LastName, a.Department as Department  FROM [TravelExpenses].[dbo].[User] as a inner join TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.UserID where a.UserID = '" + userID + "'", localCon);
                SqlDataReader userDR = user.ExecuteReader();
                while (userDR.Read())
                {
                    email = userDR["Email"].ToString();
                    fullname = userDR["Name"].ToString() + " " + userDR["LastName"].ToString();
                    department = userDR["Department"].ToString();
                }
                userDR.Close();

                string accPrEmail = "";
                SqlCommand accEmail = new SqlCommand("SELECT [Email] FROM [TravelExpenses].[dbo].[User_Email_Title] where Title = 'Accounting Processor'", localCon);
                SqlDataReader accEmailDR = accEmail.ExecuteReader();
                if (accEmailDR.HasRows)
                {
                    while (accEmailDR.Read())
                    {
                        accPrEmail = accEmailDR["Email"].ToString();
                    }
                }
                accEmailDR.Close();


                SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
                SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
                SmtpServer.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("travelAlert@lcmcd.org");
                mail.To.Add(accPrEmail);
                mail.Subject = "Review the travel of" + " " + fullname;

                


            //travel
            DateTime depDate = Convert.ToDateTime(dgvAllTravels.Rows[rowIndex].Cells[0].Value.ToString());
                DateTime retDate = Convert.ToDateTime(dgvAllTravels.Rows[rowIndex].Cells[1].Value.ToString());
                string travEvent = dgvAllTravels.Rows[rowIndex].Cells[2].Value.ToString();
                string destination = dgvAllTravels.Rows[rowIndex].Cells[5].Value.ToString();

                MailMessage empMail = new MailMessage();
                empMail.From = new MailAddress("travelAlert@lcmcd.org");
                empMail.To.Add(email);
                empMail.Subject = "Travel to " + destination;

            if (depDate.ToShortDateString() == retDate.ToShortDateString())
                {
                    mail.Body = "Please enter to the travel program and review the travel of" + " " + fullname + " " + "on" + " " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event, arriving to " + destination;

                }
                else
                {
                    mail.Body = "Please enter to the travel program and review the travel of" + " " + fullname + " " + "on" + " " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event, arriving to " + destination;
                }

            string bodyText = "In reference to the above travel that you just electronically signed, please bring to Jessica Collins all invoices/ receipts, in order for her to review your expense report(do not send them via email)." + System.Environment.NewLine + "Important: Please keep a copy of all invoices / receipts." + System.Environment.NewLine + "Thank you";
            empMail.Body = bodyText;


            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment(CommonVariables.filePath);
            //mail.Attachments.Add(attachment);
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };



                try
                {
                    SmtpServer.Send(mail);
                    SmtpServer.Send(empMail);
                MessageBox.Show("The email was sent successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                localCon.Close();
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            sendEMail();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblSendingEmail.Visible = false;
            pictureBox1.Visible = false;
            tableLayoutPanel1.Enabled = true;
            dgvAllTravels.Enabled = true;
            index = 0;
            refreshTravels();
        }

        private void generatePDF()
        {
            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";
            string departureDate = "";
            string returnDate = "";

            //cleaning the accounting variables
            travelACC = 0;
            trainingACC = 0;

            //reimbursement variables
            double mealsReimbursement = 0;
            double registratiorReimbursement = 0;
            double lodgingReimbursement = 0;
            double carRentalReimbursement = 0;
            double mileagReimbursement = 0;
            double airfareReimbursement = 0;
            double otherExpenseReimbursement = 0;


            int rowIndex = dgvAllTravels.CurrentRow.Index;
            string IdTrav = dgvAllTravels.Rows[rowIndex].Cells[8].Value.ToString();
            Guid travID = new Guid(IdTrav);

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString();
            }
            drUser.Close();
            fullName = name + " " + lastname;

            SqlCommand cmdTDates = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTDates = cmdTDates.ExecuteReader();
            while (drTDates.Read())
            {
                departureDate = Convert.ToDateTime(drTDates["DepartureDate"].ToString()).ToShortDateString();
                returnDate = Convert.ToDateTime(drTDates["ReturnDate"].ToString()).ToShortDateString();
            }
            drTDates.Close();

            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form.pdf";
            string pdfName = fullName + "_" + departureDate + "_" + "to" + "_" + returnDate + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form_" + pdfName;
            CommonVariables.filePath = newFile;

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;



            //user details
            pdfFormFields.SetField("Full Name", fullName);
            pdfFormFields.SetField("District", district);
            pdfFormFields.SetField("Department", department);

            //travel details
            SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTD = cmdTD.ExecuteReader();
            while (drTD.Read())
            {
                pdfFormFields.SetField("Travel Event", drTD["TravelEvent"].ToString());
                pdfFormFields.SetField("Travel Purpose", drTD["TravelPurpose"].ToString());
                DateTime dd = Convert.ToDateTime(drTD["DepartureDate"].ToString());
                pdfFormFields.SetField("Departure Date", dd.ToShortDateString());
                pdfFormFields.SetField("Departure Time", drTD["DepartureTime"].ToString());
                DateTime rd = Convert.ToDateTime(drTD["ReturnDate"].ToString());
                pdfFormFields.SetField("Return Date", rd.ToShortDateString());
                pdfFormFields.SetField("Return Time", drTD["ReturnTime"].ToString());
                pdfFormFields.SetField("Origin", drTD["Origin"].ToString());
                pdfFormFields.SetField("Destination", drTD["Destination"].ToString());
                pdfFormFields.SetField("Travel State", drTD["TravelState"].ToString());
                pdfFormFields.SetField("Travel Notes", drTD["Notes"].ToString());


                //Tratel Totals
                travelACC = Convert.ToDouble(drTD["TotalTravelAmount"].ToString());
                string travCost = travelACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double reimValue = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString());
                string reimCost = reimValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double noReimCostValue = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString());
                string noReimCost = noReimCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                pdfFormFields.SetField("Travel Total", travCost);
                pdfFormFields.SetField("Total Reimbursed", reimCost);
                pdfFormFields.SetField("No Reimbursed", noReimCost);

                pdfFormFields.SetField("Travel Total Cost", travCost);
                pdfFormFields.SetField("Reimbursement", reimCost);
                pdfFormFields.SetField("No Reimbursed Total", noReimCost);


                //set up the travel common variables
                if (drTD["Melas"].ToString() == "True")
                {
                    CommonVariables.isMeals = true;
                }
                if (drTD["Registration"].ToString() == "True")
                {
                    CommonVariables.isRegistartion = true;
                }
                if (drTD["CarRental"].ToString() == "True")
                {
                    CommonVariables.isCarRental = true;
                }
                if (drTD["Lodging"].ToString() == "True")
                {
                    CommonVariables.isLodging = true;
                }
                if (drTD["AirFare"].ToString() == "True")
                {
                    CommonVariables.isAirFare = true;
                }
                if (drTD["Mileage"].ToString() == "True")
                {
                    CommonVariables.isMileage = true;
                }
                if (drTD["OtherExpenses"].ToString() == "True")
                {
                    CommonVariables.isOtherExpenses = true;
                }
            }
            drTD.Close();

            //Meals Details
            if (CommonVariables.isMeals)
            {
                string mealIDvalue = "";
                SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMeals = cmdMeals.ExecuteReader();
                while (drMeals.Read())
                {
                    double mealCostValue = Convert.ToDouble(drMeals["TotalMeals"].ToString());
                    mealIDvalue = drMeals["MealsID"].ToString();
                    string mealCost = mealCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMeals", mealCost);
                    pdfFormFields.SetField("NotesMeals", drMeals["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("BreakfastQuantity", drMeals["Breakfast"].ToString());
                    pdfFormFields.SetField("LunchQuantity", drMeals["Lunch"].ToString());
                    pdfFormFields.SetField("DinnerQuantity", drMeals["Dinner"].ToString());
                    double brekCost = Convert.ToInt32(drMeals["Breakfast"].ToString()) * Convert.ToDouble(drMeals["BreakfastPerDiemRate"].ToString());
                    pdfFormFields.SetField("BreakfastCost", brekCost.ToString());
                    double lunchCost = Convert.ToInt32(drMeals["Lunch"].ToString()) * Convert.ToDouble(drMeals["LunchPerDiemRate"].ToString());
                    pdfFormFields.SetField("LunchCost", lunchCost.ToString());
                    double dinCost = Convert.ToInt32(drMeals["Dinner"].ToString()) * Convert.ToDouble(drMeals["DinnerPerDiemRate"].ToString());
                    pdfFormFields.SetField("DinnerCost", dinCost.ToString());
                    pdfFormFields.SetField("Meals Notes", drMeals["Notes"].ToString());
                    pdfFormFields.SetField("BreakfastPerDiemRate", drMeals["BreakfastPerDiemRate"].ToString());
                    pdfFormFields.SetField("LunchPerDiemRate", drMeals["LunchPerDiemRate"].ToString());
                    pdfFormFields.SetField("DinnerPerDiemRate", drMeals["DinnerPerDiemRate"].ToString());
                    pdfFormFields.SetField("TotalMealsPerDiemRate", drMeals["TotalPerDiemRate"].ToString());
                    pdfFormFields.SetField("PerDiemLoactionZipCode", drMeals["PerDiemLoactionZipCode"].ToString());
                    if (drMeals["ProvidedMeal"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Meals", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Meals", "No");
                    }
                    //string mealCost = Convert.ToDouble(drMeals["TotalMeals"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Meals_Total", mealCost);

                    //setting the value for meal reimbursement
                    mealsReimbursement = mealCostValue;
                }
                drMeals.Close();



                Guid mealID = new Guid(mealIDvalue);
                int rowInc = 1;
                SqlCommand meadDate = new SqlCommand("SELECT [Date] ,[Breaksfast],[Lunch] ,[Dinner] FROM [TravelExpenses].[dbo].[MealDate] where MealsID = '" + mealID + "' order by date asc", localCon);
                SqlDataReader meadDateDR = meadDate.ExecuteReader();
                while (meadDateDR.Read())
                {
                    DateTime date = Convert.ToDateTime(meadDateDR["Date"].ToString());
                    pdfFormFields.SetField("MealDate" + rowInc, date.ToShortDateString());
                    if (meadDateDR["Breaksfast"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Breakfast" + rowInc, "Yes");
                    }
                    if (meadDateDR["Lunch"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Lunch" + rowInc, "Yes");
                    }
                    if (meadDateDR["Dinner"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Dinner" + rowInc, "Yes");
                    }
                    rowInc++;
                }
                meadDateDR.Close();
            }

            //Registration Details
            if (CommonVariables.isRegistartion)
            {

                SqlCommand cmdRegis = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drRegis = cmdRegis.ExecuteReader();
                while (drRegis.Read())
                {
                    trainingACC = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    travelACC = travelACC - trainingACC;
                    if (travelACC < 0)
                    {
                        travelACC = travelACC * -1;
                    }
                    string totalReg = trainingACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostRegistration", totalReg);
                    pdfFormFields.SetField("NotesRegistration", drRegis["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("Registration Cost", totalReg);
                    pdfFormFields.SetField("Registartion Notes", drRegis["Notes"].ToString());
                    if (drRegis["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("District Pay Registration", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("District Pay Registration", "No");

                        //setting the value for the registration reimbursement
                        registratiorReimbursement = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    }
                }
                drRegis.Close();

            }

            //Lodging
            if (CommonVariables.isLodging)
            {

                SqlCommand cmdLod = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drLod = cmdLod.ExecuteReader();

                double totalLod = 0;
                string notes = "";
                int rowLod = 1;
                while (drLod.Read())
                {
                    totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    if (drLod["Notes"].ToString() != "")
                    {
                        notes += drLod["Notes"].ToString() + " .";
                    }

                    //details
                    pdfFormFields.SetField("Facility Name" + rowLod, drLod["FacilityName"].ToString());
                    pdfFormFields.SetField("Facility Total Cost" + rowLod, drLod["TotalLodging"].ToString());
                    //totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    pdfFormFields.SetField("Lodging Nights" + rowLod, drLod["NumberOfNights"].ToString());
                    pdfFormFields.SetField("Lodging Night Cost" + rowLod, drLod["CostPerNight"].ToString());
                    //pdfFormFields.SetField("Lodging Taxes Fees" + rowLod, drLod["TaxesAndFees"].ToString());
                    if (drLod["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Lodging District Pay" + rowLod, "Yes");
                        pdfFormFields.SetField("Lodging Director Approval" + rowLod, "");
                    }
                    else
                    {
                        pdfFormFields.SetField("Lodging District Pay" + rowLod, "No");
                        if (drLod["DirectorApproved"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + rowLod, "Yes");

                            //setting the value for the lodging reimbursement
                            lodgingReimbursement += Convert.ToDouble(drLod["TotalLodging"].ToString());
                        }
                        else
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + rowLod, "No");
                        }
                    }
                    pdfFormFields.SetField("Facility  Notes" + rowLod, drLod["Notes"].ToString());
                    rowLod++;
                }
                drLod.Close();
                string lodgCost = totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostLodgings", lodgCost);
                pdfFormFields.SetField("NotesLodgings", notes);

                pdfFormFields.SetField("Lodging Total", lodgCost);
            }

            //Car Rental Details
            if (CommonVariables.isCarRental)
            {
                SqlCommand cmdCR = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drCR = cmdCR.ExecuteReader();


                double totalCR = 0;
                string notesCR = "";
                int carRow = 1;
                while (drCR.Read())
                {
                    totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    if (drCR["Notes"].ToString() != "")
                    {
                        notesCR += drCR["Notes"].ToString() + " .";
                    }

                    //details
                    DateTime pickUp = Convert.ToDateTime(drCR["PickUPDate"].ToString());
                    pdfFormFields.SetField("Pick up Date" + carRow, pickUp.ToShortDateString());
                    DateTime dropOff = Convert.ToDateTime(drCR["DropOffDate"].ToString());
                    pdfFormFields.SetField("Drop off Date" + carRow, dropOff.ToShortDateString());
                    pdfFormFields.SetField("Car_Day Cost" + carRow, drCR["CostPerDay"].ToString());
                    pdfFormFields.SetField("Car Total" + carRow, drCR["TotalCarRental"].ToString());
                    //totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    pdfFormFields.SetField("Car Type" + carRow, drCR["CarType"].ToString());
                    pdfFormFields.SetField("Rental Company" + carRow, drCR["Company"].ToString());
                    pdfFormFields.SetField("Car Rental Days" + carRow, drCR["Days"].ToString());
                    //pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, drCR["TaxesAndFees"].ToString());
                    //pdfFormFields.SetField("LDW Insurance" + carRow, drCR["LDWInsuranse"].ToString());
                    //pdfFormFields.SetField("Supplemental Insurance" + carRow, drCR["SupplementalInsurance"].ToString());
                    //pdfFormFields.SetField("Extra Insurance" + carRow, drCR["ExtarInsuranceAmount"].ToString());
                    if (drCR["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "No");

                        //setting the value for the car rental reimbursement
                        carRentalReimbursement += Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    }
                    pdfFormFields.SetField("Car Personal Amount" + carRow, drCR["PersonalAmount"].ToString());
                    pdfFormFields.SetField("Car Notes" + carRow, drCR["Notes"].ToString());

                    carRow++;
                }
                drCR.Close();
                string carCost = totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostCar Rental", carCost);
                pdfFormFields.SetField("NotesCar Rental", notesCR);

                pdfFormFields.SetField("Car Rental Total", carCost);
            }

            //AirFare Details
            if (CommonVariables.isAirFare)
            {
                SqlCommand cmdAF = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drAF = cmdAF.ExecuteReader();

                double totalAF = 0;
                string notesAF = "";
                int flightRow = 1;

                while (drAF.Read())
                {
                    totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    if (drAF["Notes"].ToString() != "")
                    {
                        notesAF += drAF["Notes"].ToString() + " .";
                    }

                    //details
                    DateTime depDateFligh = Convert.ToDateTime(drAF["DepartureDate"].ToString());
                    pdfFormFields.SetField("Flight_Departure Date" + flightRow, depDateFligh.ToShortDateString());
                    if (drAF["ReturnDate"].ToString() != "")
                    {
                        DateTime rd = Convert.ToDateTime(drAF["ReturnDate"].ToString());
                        pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString());
                    }
                    pdfFormFields.SetField("Flight Total" + flightRow, drAF["AirFareTotal"].ToString());
                    //totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    //pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, drAF["TaxesAndFees"].ToString());
                    if (drAF["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "No");

                        //setting the value for the airfare reimbursement
                        airfareReimbursement += Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    }
                    pdfFormFields.SetField("Flight Personal Amount" + flightRow, drAF["PersonalUseAmount"].ToString());
                    pdfFormFields.SetField("Air Fare Notes" + flightRow, drAF["Notes"].ToString());

                    flightRow++;
                }
                drAF.Close();
                string flightCost = totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostAir Fare", flightCost);
                pdfFormFields.SetField("NotesAir Fare", notesAF);

                pdfFormFields.SetField("Air Fare Total", flightCost);
            }

            //Mileage Details
            if (CommonVariables.isMileage)
            {
                SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMi = cmdMi.ExecuteReader();

                while (drMi.Read())
                {
                    double milCostValue = Convert.ToDouble(drMi["TotalMileage"].ToString());
                    string milcost = milCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMileage", milcost);
                    pdfFormFields.SetField("NotesMileage", drMi["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("Map Mileage", drMi["MapMileage"].ToString());
                    pdfFormFields.SetField("Vicinity Mileage", drMi["VicinityMileage"].ToString());
                    string milCost = Convert.ToDouble(drMi["TotalMileage"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Mileage Cost", milCost);
                    if (drMi["DistrictVehicleProvided"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Vehicle", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Vehicle", "No");
                        if (drMi["DirectorApprovedPersonal"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "Yes");

                            //setting the value for the mileage reimbursement
                            mileagReimbursement = Convert.ToDouble(drMi["TotalMileage"].ToString());
                        }
                        else
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "No");
                        }
                    }
                    pdfFormFields.SetField("Mileage Notes", drMi["Notes"].ToString());
                }
                drMi.Close();
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses)
            {
                SqlCommand cmdOE = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drOE = cmdOE.ExecuteReader();

                double totalOE = 0;
                string notesOE = "";
                int oxRow = 1;
                while (drOE.Read())
                {
                    totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    if (drOE["Notes"].ToString() != "")
                    {
                        notesOE += drOE["Notes"].ToString() + " .";
                    }

                    //details
                    pdfFormFields.SetField("ExpDescription" + oxRow, drOE["Description"].ToString());
                    pdfFormFields.SetField("ExpCost" + oxRow, drOE["Amount"].ToString());
                    //totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    pdfFormFields.SetField("ExpNotes" + oxRow, drOE["Notes"].ToString());

                    if (drOE["Prepaid"].ToString() == "True")
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "No");

                        //setting the value for the other expenses reimbursement
                        otherExpenseReimbursement += Convert.ToDouble(drOE["Amount"].ToString());
                    }

                    oxRow++;
                }
                drOE.Close();
                string oeCost = totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostOther Expenses", oeCost);
                pdfFormFields.SetField("NotesOther Expenses", notesOE);

                pdfFormFields.SetField("Other Expenses Total", oeCost);
            }

            //Accounting accounts
            string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Travel4000", travACC);
            string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Training5500", trainACC);


            //Reimbursement Table
            pdfFormFields.SetField("Meals_Reimbursement", mealsReimbursement.ToString());
            pdfFormFields.SetField("Registration_Reimbursement", registratiorReimbursement.ToString());
            pdfFormFields.SetField("Lodgings_Reimbursement", lodgingReimbursement.ToString());
            pdfFormFields.SetField("CarRental_Reimbursement", carRentalReimbursement.ToString());
            pdfFormFields.SetField("Airfare_Reimbursement", airfareReimbursement.ToString());
            pdfFormFields.SetField("Mileage_Reimbursement", mileagReimbursement.ToString());
            pdfFormFields.SetField("OtherExpenses_Reimbursement", otherExpenseReimbursement.ToString());

            //Signatures
            SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travID + "'  AND a.TravelType = 'Travel'", localCon);
            SqlDataReader drPDF = cmdPDF.ExecuteReader();
            if (drPDF.HasRows)
            {
                while (drPDF.Read())
                {

                    BaseFont bf = BaseFont.CreateFont();
                    if (drPDF["FontType"].ToString() == "Mistral")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Rage Italic")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "MV Boli")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Bradley Hand ITC")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Script MT Bold")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }

                    DateTime sigDate = Convert.ToDateTime(drPDF["SignatureDate"].ToString());
                    if (drPDF["UserType"].ToString() == "Accounting")
                    {
                        pdfFormFields.SetFieldProperty("Finance Review Siganature", "textfont", bf, null);
                        pdfFormFields.SetField("Finance Review Siganature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Finance Review", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Supervisor")
                    {
                        pdfFormFields.SetFieldProperty("Supervisor Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Supervisor Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Supervisor Date", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Employee")
                    {
                        pdfFormFields.SetFieldProperty("Employee Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Employee Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Employee Date", sigDate.ToShortDateString());
                    }

                }
            }
            drPDF.Close();

            pdfStamper.Close();
            localCon.Close();


        }




    }
        
}
