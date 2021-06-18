'Author: Chantelle Marek
'Purpose: To keep track/log infromation about fishing trips
'Date: 03/05/2020

'I would have included an edit feature, but while working on it
'I couldn't get it to function. Then deleteing or inserting records
'would stop working.

Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmFishLog

    'Module Level Objects
    Dim objSelectedFish As Fish
    Dim lstFish As New BindingList(Of Fish)
    Dim objFish As New Fish()
    Dim Fish As New Fish()

    Private Sub frmFishLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate Time of Day Combo Box
        cbxTimeDay.Items.Add("Morning")
        cbxTimeDay.Items.Add("Afternoon")
        cbxTimeDay.Items.Add("Night")
        cbxTimeDay.SelectedIndex = 0

        'lbxTripDate Display
        'Bind Binding List
        lbxTripDate.DataSource = lstFish
        lbxTripDate.DisplayMember = "FishID"

        'Reload
        Reload_lbxTripDate()

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Assign Fish information from frmFishLog
        objFish.Species = txtSpecies.Text
        objFish.Weight = CDec(txtWeight.Text)
        objFish.Length = CDec(txtLength.Text)
        objFish.FishID = txtFishID.Text
        objFish.Location = txtLocation.Text
        objFish.DateFished = txtTripDate.Text
        objFish.TimeDay = cbxTimeDay.SelectedItem.ToString
        objFish.WaterClarity = txtClarity.Text
        objFish.Technique = txtTechnique.Text

        'Make new Fish the selected character
        objSelectedFish = objFish
        'Add fish to list
        lstFish.Add(objFish)
        'Select current item for list box
        lbxTripDate.SelectedItem = objFish

        'Insert Fish
        InsertCommand()

        'Log Display
        DisplayLog()

    End Sub
    Private Sub Reload_lbxTripDate()
        'Clear listbox
        lstFish.Clear()

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a command object
        Dim cmdSelect As New SqlCommand("SELECT * FROM FishDB_Tbl;", dbConnection)

        'Execute Command into a DataReader
        Dim rdrFish As SqlDataReader = cmdSelect.ExecuteReader

        If rdrFish.HasRows Then
            While rdrFish.Read
                Dim objStoredFish As New Fish()
                objStoredFish.FishID = rdrFish.Item("Fish_ID").ToString
                objStoredFish.Species = rdrFish.Item("Species").ToString
                objStoredFish.Weight = CDec(rdrFish.Item("Weight").ToString)
                objStoredFish.Length = CDec(rdrFish.Item("Length").ToString)
                objStoredFish.Location = rdrFish.Item("Location").ToString
                objStoredFish.DateFished = rdrFish.Item("Date").ToString
                objStoredFish.TimeDay = rdrFish.Item("TimeOfDay").ToString
                objStoredFish.WaterClarity = rdrFish.Item("WaterClarity").ToString
                objStoredFish.Technique = rdrFish.Item("Technique").ToString

                lstFish.Add(objStoredFish)
            End While
        End If

        'Close and Dispose DB Connection
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub
    Private Sub lbxTripDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxTripDate.SelectedIndexChanged
        If Not lbxTripDate Is Nothing Then
            objSelectedFish = CType(lbxTripDate.SelectedItem, Fish)
            DisplayLog()
        Else
            objSelectedFish = Nothing
            DisplayLog()
        End If

    End Sub
    Private Sub DisplayLog()

        'Measurement units
        Dim strWeightUnit As String = " lbs."
        Dim strLengthUnit As String = " in."

        'Display selected log
        lblSpeciesOutput.Text = objSelectedFish.Species
        lblDateOutput.Text = objSelectedFish.DateFished
        lblTimeOutput.Text = objSelectedFish.TimeDay
        lblLocationOutput.Text = objSelectedFish.Location
        lblClarityOutput.Text = objSelectedFish.WaterClarity
        lblTechOutput.Text = objSelectedFish.Technique
        lblLengthOutput.Text = CType(objSelectedFish.Length, String) & strLengthUnit
        lblWeightOutput.Text = CType(objSelectedFish.Weight, String) & strWeightUnit
        lblIDOutput.Text = CType(objSelectedFish.FishID, String)

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear input
        ClearInput()

    End Sub
    Private Sub ClearInput()
        'Clear Text and Combo Boxes
        txtSpecies.Text = String.Empty
        txtWeight.Text = "0"
        txtLength.Text = "0"
        txtFishID.Text = String.Empty
        txtLocation.Text = String.Empty
        txtTripDate.Text = "--/--/----"
        cbxTimeDay.SelectedIndex = 0
        txtClarity.Text = String.Empty
        txtTechnique.Text = String.Empty

    End Sub
    Public Sub InsertCommand()
        'InsertFish is inserting data into the Database
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSQL = "INSERT INTO FishDB_Tbl (Species,Weight,Length,Location,Date,TimeOfDay,WaterClarity,Technique) values (@Species,@Weight,@Length,@Location,@Date,@TimeOfDay,@WaterClarity,@Technique)"

        'Create Insert Command
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate Parameters of the insert
        cmdInsert.Parameters.AddWithValue("Species", lstFish.Last.Species)
        cmdInsert.Parameters.AddWithValue("Weight", lstFish.Last.Weight)
        cmdInsert.Parameters.AddWithValue("Length", lstFish.Last.Length)
        cmdInsert.Parameters.AddWithValue("Location", lstFish.Last.Location)
        cmdInsert.Parameters.AddWithValue("Date", lstFish.Last.DateFished)
        cmdInsert.Parameters.AddWithValue("TimeOfDay", lstFish.Last.TimeDay)
        cmdInsert.Parameters.AddWithValue("WaterClarity", lstFish.Last.WaterClarity)
        cmdInsert.Parameters.AddWithValue("Technique", lstFish.Last.Technique)

        Try
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show(lstFish.Last.FishID & " was inserted.")
            Else
                MessageBox.Show("The insert failed!")
            End If
        Catch ex As Exception
            MessageBox.Show("DB Insert Failed!" & ex.Message)
        End Try

        'Close database connection
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create sql string
        Dim strSQL = "DELETE FROM FishDB_Tbl WHERE Fish_ID = '" & objSelectedFish.FishID & "'"
        MessageBox.Show(strSQL)

        'Create command object
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)

        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery()
            If intRowsAffected = 1 Then
                MessageBox.Show("Record was deleted")
            Else
                MessageBox.Show("The delete failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("DB Delete Failed. " & ex.Message)
        End Try

        'Remove deleted Fish
        lstFish.Remove(objSelectedFish)
        objSelectedFish = CType(lbxTripDate.SelectedItem, Fish)

        'Display
        DisplayLog()

        'Close database connection
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub
    Private Function OpenDBConnection() As SqlConnection
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)

        Dim strconnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "FishDB.mdf"

        'Create a Connection Object
        Dim dbConnection As New SqlConnection(strconnection)

        Try
            'Open Database
            dbConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dbConnection

    End Function
End Class
