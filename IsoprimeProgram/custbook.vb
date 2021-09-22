Public Class custbook

    Private Sub custbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IsoprimeDBDataSet.addressTable' table. You can move, or remove it, as needed.
        Me.AddressTableTableAdapter.Fill(Me.IsoprimeDBDataSet.addressTable)
    End Sub

    Private Sub AddressTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AddressTableBindingNavigatorSaveItem.Click
        updateButton.PerformClick()
        'call the update button 
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit()
        'exits the program
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        addButton.PerformClick()
        'call add button
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        deleteButton.PerformClick()
        'call delete button
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        'if the user wants to delete a person from the DB
        'this will first try to see if it is possible, 
        'then prompt the user if they are sure they want to remove it
        'if so delete it
        Try
            If MessageBox.Show("Are you sure you want to delete?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                AddressTableBindingSource.RemoveCurrent()
                AddressTableBindingSource.EndEdit()
                AddressTableTableAdapter.Update(IsoprimeDBDataSet.addressTable)
                RefreshDB()
                MessageBox.Show("Delete successful")
            Else
                Return
            End If

        Catch ex As Exception
            MsgBox("An Error Occured: " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Delete failed"
                   )
        End Try
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        'first will test if the user can add someone
        'next it will change the button names to "Cancel" to stop it
        'one it is added, the button name reverts and it will prompt the user with a success message
        Try
            With addButton
                If .Text = "Add New" Then
                    AddressTableBindingSource.AddNew()
                    .Text = "Cancel"
                Else
                    RefreshDB()
                    .Text = "Add New"
                End If
            End With

            With DobDateTimePicker
                If (.CanSelect) Then
                    .Text = .MinDate
                End If
            End With
            With PhoneNumTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                End If
            End With
            With PersonAddressTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                End If
            End With

        Catch ex As Exception
            MsgBox("An Error Occured: " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Adding failed"
                         )
        End Try
    End Sub

    Private Sub RefreshDB()
        'this will refresh the data and make sure it is up to date any time the user adds/updates/removes something 
        Try
            Me.AddressTableBindingSource.Filter = Nothing
            Me.AddressTableTableAdapter.Fill(Me.IsoprimeDBDataSet.addressTable)
        Catch ex As Exception
            MsgBox("Refreshing failed")
        End Try
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        'first checks if the user can update the data
        'next it prompts the user with the option to cancel
        'if they wish to continue then it will update and refresh

        'NOTE: YOU MUST CLICK THIS TO SAVE THE DATA DOR ADDING. I WAS GOING TO MAKE A HIDEN BUTTON BUT SINCE THEY WERE THE SAME I COMBINED THEM
        Try
            Dim input As DialogResult
            input = MessageBox.Show("Are you sure you want to update?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (input = DialogResult.Yes) Then
                Validate()
                AddressTableBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.IsoprimeDBDataSet)

                MessageBox.Show("Update successful")

                RefreshDB()
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox("An Error Occured: " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Saving failed"
                   )
        End Try
    End Sub

    'Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
    '
    '   End Sub
End Class
