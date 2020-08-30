Module Module1
    Sub TitikKoma(e As KeyPressEventArgs, TextBox As TextBox)

        Select Case e.KeyChar

            Case CChar(vbBack) 'JIKA TOMBOL BACKSPACE

                e.Handled = False 'LANJUT INPUT

            Case "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c 'JIKA TOMBOL 0-9

                e.Handled = False

            Case "-"c 'JIKA TOMBOL - (MINUS)

                If TextBox.Text.Contains("-"c) = True Then 'JIKA TEXTBOX SUDAH PUNYA HURUF MINUS

                    e.Handled = True 'STOP INPUT

                Else 'JIKA TEXTBOX BELUM ADA HURUF MINUS

                    If TextBox.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG

                        e.Handled = False 'LANJUT INPUT HURUF MINUS

                    Else 'JIKA BELUM ADA HURUF MINUS TAPI SUDAH ADA ANGKA

                        e.Handled = True 'STOP INPUT HURUF MINUS

                    End If

                End If

            Case CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) 'JIKA TOMBOL PEMISAH DESIMAL

                'JIKA SUDAH ADA HURUF PEMISAH DESIMAL

                If TextBox.Text.Contains(CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)) = True Then

                    e.Handled = True 'STOP INPUT

                Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL

                    If TextBox.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        'TAMBAHKAN O (NOL) DIDEPAN HURUF PEMISAH DESIMAL

                        TextBox.Text = "0"c & CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)

                        e.Handled = True  'STOP INPUT

                        'PINDAHKAN CURSOR DITEXTBOX KE BELAKANG TEXT

                        TextBox.Select(TextBox.Text.Length, 0)

                    Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL TAPI SUDAH ADA ANGKA

                        e.Handled = False 'LANJUT INPUT

                    End If

                End If

            Case CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator) 'JIKA TOMBOL PEMISAH RIBUAN

                'JIKA SUDAH ADA HURUF PEMISAH DESIMAL

                If TextBox.Text.Contains(CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)) = True Then

                    e.Handled = True 'STOP INPUT

                Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL

                    If TextBox.Text = String.Empty Then 'JIKA TEXTBOX MASIH KOSONG
                        'TAMBAHKAN O (NOL) DIDEPAN HURUF PEMISAH DESIMAL

                        TextBox.Text = "0"c & CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)

                        e.Handled = True  'STOP INPUT

                        'PINDAHKAN CURSOR DITEXTBOX KE BELAKANG TEXT

                        TextBox.Select(TextBox.Text.Length, 0)

                    Else 'JIKA BELUM ADA HURUF PEMISAH DESIMAL TAPI SUDAH ADA ANGKA

                        e.KeyChar = CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator) 'LANJUT INPUT TAPI HURUFNYA DIUBAH

                    End If

                End If

            Case Else 'JIKA BUKA TOMBOL BACKSPACE, 0-9, -, PEMISAH DESIMAL, PEMISAH RIBUAN

                e.Handled = True 'STOP INPUT

        End Select

    End Sub
End Module
