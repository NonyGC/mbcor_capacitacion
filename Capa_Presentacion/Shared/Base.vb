Imports System.Windows.Forms
Public Class Base
    Shared Sub Solo_numeros(e As KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Shared Sub Solo_Letras(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Shared Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890.", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function
    Shared Sub solo_decimales(e As KeyPressEventArgs, ByVal Texto As String)
        If Char.IsNumber(e.KeyChar) Or InStr(".", e.KeyChar) = 1 Then
            If IsNumeric(Texto) = True Then
                e.Handled = False
            ElseIf IsNumeric(Texto) = False Then
                e.Handled = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Shared Sub RadioButtonclear(grpbx As GroupBox)
        For Each element As Control In grpbx.Controls
            If TypeOf element Is RadioButton Then
                If DirectCast(element, RadioButton).Checked Then
                    DirectCast(element, RadioButton).Checked = False
                End If
            End If
        Next
    End Sub
    Shared Sub CheckBoxclear(grpbx As GroupBox)
        For Each element As Control In grpbx.Controls
            If TypeOf element Is CheckBox Then
                If DirectCast(element, CheckBox).Checked Then
                    DirectCast(element, CheckBox).Checked = False
                End If
            End If
        Next
    End Sub
End Class
