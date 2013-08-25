' Tyler Normile
' 4.4.2013
' Sales Report App

Public Class SalesReportForm

    Dim itemCount As Integer = 0
    Dim itemNames(0 To 9) As String
    Dim itemSales As Decimal(,) = New Decimal(0 To 9, 0 To 4) {}

    ' Display the sales report
    Sub DisplaySales()

        ' clear the ListBox
        outputListBox.Items.Clear()

        ' create a header for the ListBox
        outputListBox.Items.Add("Name" & ControlChars.Tab &
         ControlChars.Tab & "Mon." & ControlChars.Tab & "Tue." &
         ControlChars.Tab & "Wed." & ControlChars.Tab & "Thu." &
         ControlChars.Tab & "Fri." & ControlChars.Tab & "Total")

        Dim output As String
        Dim counterItem As Integer = 0
        Dim counterDay As Integer = 4
        Dim weekTotal As Decimal = 0 ' weekly sales total
        Dim salesTotal As Decimal = 0 ' total sales

        ' Loop thru items as they are entered
        For item As Integer = 0 To itemCount - 1
            output = itemNames(item) & ControlChars.Tab & ControlChars.Tab

            ' Loop thry days of the week
            For day As Integer = 0 To counterDay
                output &= String.Format("{0:c}", itemSales(counterItem, day)) & ControlChars.Tab
                weekTotal += itemSales(counterItem, day)
            Next day

            ' output item weekly totals
            output &= String.Format("{0:c}", weekTotal)
            outputListBox.Items.Add(output)
            ' update item count
            counterItem += 1
            ' calc gross total as items are added
            salesTotal += weekTotal
            'clear weekly total after each item
            weekTotal = 0
            'output of update gross total into label
            grossSalesLabel.Text = String.Format("{0:c}", salesTotal)
        Next item

    End Sub ' DisplaySales

    Private Sub submitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitButton.Click

        If mondayTextBox.Text = "" Or tuesdayTextBox.Text = "" Or wednesdayTextBox.Text = "" Or thursdayTextBox.Text = "" Or fridayTextBox.Text = "" Then
            MsgBox("Please enter a value for all days!")
        Else
            If Not IsNumeric(mondayTextBox.Text) Or Not IsNumeric(tuesdayTextBox.Text) Or Not IsNumeric(wednesdayTextBox.Text) Or Not IsNumeric(thursdayTextBox.Text) Or Not IsNumeric(fridayTextBox.Text) Then
                MsgBox("Numbers are only allowed in Monday-Friday input fields!")
            Else

                itemNames(itemCount) = itemTextBox.Text ' retrieve item name
                ' retrieve sales data for each day
                itemSales(itemCount, 0) = Convert.ToDecimal(mondayTextBox.Text)
                itemSales(itemCount, 1) = Convert.ToDecimal(tuesdayTextBox.Text)
                itemSales(itemCount, 2) = Convert.ToDecimal(wednesdayTextBox.Text)
                itemSales(itemCount, 3) = Convert.ToDecimal(thursdayTextBox.Text)
                itemSales(itemCount, 4) = Convert.ToDecimal(fridayTextBox.Text)

                itemCount += 1 'update number of items added

                If itemCount = 10 Then
                    submitButton.Enabled = False 'disable submit button after 10 items are entered
                End If

                'call sub to add item name and sales to listbox and calculate Gross Sales
                DisplaySales()

                'clear form contents after each item is added *** just made sense to do it ***
                itemTextBox.Clear()
                mondayTextBox.Clear()
                tuesdayTextBox.Clear()
                wednesdayTextBox.Clear()
                thursdayTextBox.Clear()
                fridayTextBox.Clear()

                'place focus back on itemTextBox
                itemTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub SalesReportForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class ' SalesReportForm

