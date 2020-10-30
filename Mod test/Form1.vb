Public Class Form1

	Public Shared thirtyonev As Double = 0
	Public Shared thirtyv As Double = 0
	Public Shared twentyninev As Double = 0
	Public Shared twentyeightv As Double = 0
	Public Shared twentysevenv As Double = 0
	Public Shared twentysixv As Double = 0
	Public Shared twentyfivev As Double = 0
	Public Shared twentyfourv As Double = 0
	Public Shared twentythreev As Double = 0
	Public Shared twentytwov As Double = 0
	Public Shared twentyonev As Double = 0
	Public Shared twentyv As Double = 0
	Public Shared nineteenv As Double = 0
	Public Shared eighteenv As Double = 0
	Public Shared seventeenv As Double = 0
	Public Shared sixteenv As Double = 0
	Public Shared fifteenv As Double = 0
	Public Shared fourteenv As Double = 0
	Public Shared thirteenv As Double = 0
	Public Shared twelvev As Double = 0
	Public Shared elevenv As Double = 0
	Public Shared tenv As Double = 0
	Public Shared ninev As Double = 0
	Public Shared eightv As Double = 0
	Public Shared sevenv As Double = 0
	Public Shared sixv As Double = 0
	Public Shared fivev As Double = 0
	Public Shared fourv As Double = 0
	Public Shared threev As Double = 0
	Public Shared twov As Double = 0
	Public Shared onev As Double = 0
	Public Shared zerov As Double = 0

	Public Shared mul2 As Double = 0
	Public Shared fin2 As Double = 0

	Public Shared mul4 As Double = 0
	Public Shared fin4 As Double = 0

	Public Shared mul8 As Double = 0
	Public Shared fin8 As Double = 0

	Public Shared mul16 As Double = 0
	Public Shared fin16 As Double = 0

	Public Shared mul32 As Double = 0
	Public Shared fin32 As Double = 0

	Public Shared mul64 As Double = 0
	Public Shared fin64 As Double = 0

	Public Shared mul128 As Double = 0
	Public Shared fin128 As Double = 0

	Public Shared mul256 As Double = 0
	Public Shared fin256 As Double = 0

	Public Shared mul512 As Double = 0
	Public Shared fin512 As Double = 0

	Public Shared mul1024 As Double = 0
	Public Shared fin1024 As Double = 0

	Public Shared mul2048 As Double = 0
	Public Shared fin2048 As Double = 0

	Public Shared mul4096 As Double = 0
	Public Shared fin4096 As Double = 0

	Public Shared mul8192 As Double = 0
	Public Shared fin8192 As Double = 0

	Public Shared mul16384 As Double = 0
	Public Shared fin16384 As Double = 0

	Public Shared fexp1 As Double = 0
	Public Shared fexp2 As Double = 0
	Public Shared fexp3 As Double = 0
	Public Shared fexp4 As Double = 0
	Public Shared fexp5 As Double = 0
	Public Shared fexp6 As Double = 0
	Public Shared fexp7 As Double = 0
	Public Shared fexp8 As Double = 0
	Public Shared fexp9 As Double = 0
	Public Shared fexp10 As Double = 0
	Public Shared fexp11 As Double = 0
	Public Shared fexp12 As Double = 0
	Public Shared fexp13 As Double = 0
	Public Shared fexp14 As Double = 0
	Public Shared fexp15 As Double = 0
	Public Shared fexp16 As Double = 0

	Public Shared ffexp1 As Double = 0
	Public Shared ffexp2 As Double = 0
	Public Shared ffexp3 As Double = 0
	Public Shared ffexp4 As Double = 0
	Public Shared ffexp5 As Double = 0
	Public Shared ffexp6 As Double = 0
	Public Shared ffexp7 As Double = 0
	Public Shared ffexp8 As Double = 0

	Public Shared fffexp1 As Double = 0
	Public Shared fffexp2 As Double = 0
	Public Shared fffexp3 As Double = 0
	Public Shared fffexp4 As Double = 0

	Public Shared ffffexp1 As Double = 0
	Public Shared ffffexp2 As Double = 0

	Public Shared fffexp As Double = 0

	Public Shared fexp As Double = 0

	Public Shared dexp As Double = 0

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		'-----------------------------------[1]-----------------------------------'

		If exp.Text = 1 Then
			res.Text = base.Text


			'-----------------------------------[2]-----------------------------------'

		ElseIf exp.Text = 2 Then
			mul2 = CLng(base.Text) * CLng(base.Text)
			fin2 = mul2 Mod modu.Text
			res.Text = fin2


			'-----------------------------------[4]-----------------------------------'

		ElseIf exp.Text = 4 Then
			mul4 = CLng(fin2) * CLng(fin2)
			fin4 = mul4 Mod modu.Text
			res.Text = fin4


			'-----------------------------------[8]-----------------------------------'

		ElseIf exp.Text = 8 Then
			mul8 = CLng(fin4) * CLng(fin4)
			fin8 = mul8 Mod modu.Text
			res.Text = fin8


			'-----------------------------------[16]-----------------------------------'

		ElseIf exp.Text = 16 Then
			mul16 = CLng(fin8) * CLng(fin8)
			fin16 = mul16 Mod modu.Text
			res.Text = fin16


			'-----------------------------------[32]-----------------------------------'

		ElseIf exp.Text = 32 Then
			mul32 = CLng(fin16) * CLng(fin16)
			fin32 = mul32 Mod modu.Text
			res.Text = fin32


			'-----------------------------------[64]-----------------------------------'

		ElseIf exp.Text = 64 Then
			mul64 = CLng(fin32) * CLng(fin32)
			fin64 = mul64 Mod modu.Text
			res.Text = fin64


			'-----------------------------------[128]-----------------------------------'

		ElseIf exp.Text = 128 Then
			mul128 = CLng(fin64) * CLng(fin64)
			fin128 = mul128 Mod modu.Text
			res.Text = fin128


			'-----------------------------------[256]-----------------------------------'

		ElseIf exp.Text = 256 Then
			mul256 = CLng(fin128) * CLng(fin128)
			fin256 = mul256 Mod modu.Text
			res.Text = fin256


			'-----------------------------------[512]-----------------------------------'

		ElseIf exp.Text = 512 Then
			mul512 = CLng(fin256) * CLng(fin256)
			fin512 = mul512 Mod modu.Text
			res.Text = fin512


			'-----------------------------------[1024]-----------------------------------'

		ElseIf exp.Text = 1024 Then
			mul1024 = CLng(fin512) * CLng(fin512)
			fin1024 = mul1024 Mod modu.Text
			res.Text = fin1024

			'-----------------------------------[2048]-----------------------------------'

		ElseIf exp.Text = 2048 Then
			mul2048 = CLng(fin1024) * CLng(fin1024)
			fin2048 = mul2048 Mod modu.Text
			res.Text = fin2048

			'-----------------------------------[4096]-----------------------------------'

		ElseIf exp.Text = 4096 Then
			mul4096 = CLng(fin2048) * CLng(fin2048)
			fin4096 = mul4096 Mod modu.Text
			res.Text = fin4096

			'-----------------------------------[8192]-----------------------------------'

		ElseIf exp.Text = 8192 Then
			mul8192 = CLng(fin4096) * CLng(fin4096)
			fin8192 = mul8192 Mod modu.Text
			res.Text = fin8192

			'-----------------------------------[16384]-----------------------------------'

		ElseIf exp.Text = 16384 Then
			mul16384 = CLng(fin8192) * CLng(fin8192)
			fin16384 = mul16384 Mod modu.Text
			res.Text = fin16384

			'-----------------------------------[Else]-----------------------------------'

		Else
			Dim i As Integer = CLng(exp.Text)
			Dim s As String = Convert.ToString(i, 2).PadLeft(32, "0"c) '32 bits

			'-----------------------------------[Char]-----------------------------------'


			Dim zero As Integer = CLng(s.Substring(0, 1))
			Dim one As Integer = CLng(s.Substring(1, 1))
			Dim two As Integer = CLng(s.Substring(2, 1))
			Dim three As Integer = CLng(s.Substring(3, 1))
			Dim four As Integer = CLng(s.Substring(4, 1))
			Dim five As Integer = CLng(s.Substring(5, 1))
			Dim six As Integer = CLng(s.Substring(6, 1))
			Dim seven As Integer = CLng(s.Substring(7, 1))
			Dim eight As Integer = CLng(s.Substring(8, 1))
			Dim nine As Integer = CLng(s.Substring(9, 1))
			Dim ten As Integer = CLng(s.Substring(10, 1))
			Dim eleven As Integer = CLng(s.Substring(11, 1))
			Dim twelve As Integer = CLng(s.Substring(12, 1))
			Dim thirteen As Integer = CLng(s.Substring(13, 1))
			Dim fourteen As Integer = CLng(s.Substring(14, 1))
			Dim fifteen As Integer = CLng(s.Substring(15, 1))
			Dim sixteen As Integer = CLng(s.Substring(16, 1))
			Dim seventeen As Integer = CLng(s.Substring(17, 1))
			Dim eighteen As Integer = CLng(s.Substring(18, 1))
			Dim nineteen As Integer = CLng(s.Substring(19, 1))
			Dim twenty As Integer = CLng(s.Substring(20, 1))
			Dim twentyone As Integer = CLng(s.Substring(21, 1))
			Dim twentytwo As Integer = CLng(s.Substring(22, 1))
			Dim twentythree As Integer = CLng(s.Substring(23, 1))
			Dim twentyfour As Integer = CLng(s.Substring(24, 1))
			Dim twentyfive As Integer = CLng(s.Substring(25, 1))
			Dim twentysix As Integer = CLng(s.Substring(26, 1))
			Dim twentyseven As Integer = CLng(s.Substring(27, 1))
			Dim twentyeight As Integer = CLng(s.Substring(28, 1))
			Dim twentynine As Integer = CLng(s.Substring(29, 1))
			Dim thirty As Integer = CLng(s.Substring(30, 1))
			Dim thirtyone As Integer = CLng(s.Substring(31, 1))

			'-----------------------------------[Bin]-----------------------------------'


			If thirtyone = 1 Then
				thirtyonev = 2 ^ 0
			Else
				thirtyonev = 0
			End If

			If thirty = 1 Then
				thirtyv = 2 ^ 1
			Else
				thirtyv = 0
			End If

			If twentynine = 1 Then
				twentyninev = 2 ^ 2
			Else
				twentyninev = 0
			End If

			If twentyeight = 1 Then
				twentyeightv = 2 ^ 3
			Else
				twentyeightv = 0
			End If

			If twentyseven = 1 Then
				twentysevenv = 2 ^ 4
			Else
				twentysevenv = 0
			End If

			If twentysix = 1 Then
				twentysixv = 2 ^ 5
			Else
				twentysixv = 0
			End If

			If twentyfive = 1 Then
				twentyfivev = 2 ^ 6
			Else
				twentyfivev = 0
			End If

			If twentyfour = 1 Then
				twentyfourv = 2 ^ 7
			Else
				twentyfourv = 0
			End If

			If twentythree = 1 Then
				twentythreev = 2 ^ 8
			Else
				twentythreev = 0
			End If

			If twentytwo = 1 Then
				twentytwov = 2 ^ 9
			Else
				twentytwov = 0
			End If

			If twentyone = 1 Then
				twentyonev = 2 ^ 10
			Else
				twentyonev = 0
			End If

			If twenty = 1 Then
				twentyv = 2 ^ 11
			Else
				twentyv = 0
			End If

			If nineteen = 1 Then
				nineteenv = 2 ^ 12
			Else
				nineteenv = 0
			End If

			If eighteen = 1 Then
				eighteenv = 2 ^ 13
			Else
				eighteenv = 0
			End If

			If seventeen = 1 Then
				seventeenv = 2 ^ 14
			Else
				seventeenv = 0
			End If

			If sixteen = 1 Then
				sixteenv = 2 ^ 15
			Else
				sixteenv = 0
			End If

			If fifteen = 1 Then
				fifteenv = 2 ^ 16
			Else
				fifteenv = 0
			End If

			If fourteen = 1 Then
				fourteenv = 2 ^ 17
			Else
				fourteenv = 0
			End If

			If thirteen = 1 Then
				thirteenv = 2 ^ 18
			Else
				thirteenv = 0
			End If

			If twelve = 1 Then
				twelvev = 2 ^ 19
			Else
				twelvev = 0
			End If

			If eleven = 1 Then
				elevenv = 2 ^ 20
			Else
				elevenv = 0
			End If

			If ten = 1 Then
				tenv = 2 ^ 21
			Else
				tenv = 0
			End If

			If nine = 1 Then
				ninev = 2 ^ 22
			Else
				ninev = 0
			End If

			If eight = 1 Then
				eightv = 2 ^ 23
			Else
				eightv = 0
			End If

			If seven = 1 Then
				sevenv = 2 ^ 24
			Else
				sevenv = 0
			End If

			If six = 1 Then
				sixv = 2 ^ 25
			Else
				sixv = 0
			End If

			If five = 1 Then
				fivev = 2 ^ 26
			Else
				fivev = 0
			End If

			If four = 1 Then
				fourv = 2 ^ 27
			Else
				fourv = 0
			End If

			If three = 1 Then
				threev = 2 ^ 28
			Else
				threev = 0
			End If

			If two = 1 Then
				twov = 2 ^ 29
			Else
				twov = 0
			End If

			If one = 1 Then
				onev = 2 ^ 30
			Else
				onev = 0
			End If

			If zero = 1 Then
				zerov = 2 ^ 31 - 1
			Else
				zerov = 0
			End If


			'-----------------------------------[Mult]-----------------------------------'


			mul2 = CLng(base.Text) * CLng(base.Text)
			fin2 = mul2 Mod modu.Text
			mul4 = CLng(fin2) * CLng(fin2)
			fin4 = mul4 Mod modu.Text
			mul8 = CLng(fin4) * CLng(fin4)
			fin8 = mul8 Mod modu.Text
			mul16 = CLng(fin8) * CLng(fin8)
			fin16 = mul16 Mod modu.Text
			mul32 = CLng(fin16) * CLng(fin16)
			fin32 = mul32 Mod modu.Text
			mul64 = CLng(fin32) * CLng(fin32)
			fin64 = mul64 Mod modu.Text
			mul128 = CLng(fin64) * CLng(fin64)
			fin128 = mul128 Mod modu.Text
			mul256 = CLng(fin128) * CLng(fin128)
			fin256 = mul256 Mod modu.Text
			mul512 = CLng(fin256) * CLng(fin256)
			fin512 = mul512 Mod modu.Text
			mul1024 = CLng(fin512) * CLng(fin512)
			fin1024 = mul1024 Mod modu.Text
			mul2048 = CLng(fin1024) * CLng(fin1024)
			fin2048 = mul2048 Mod modu.Text
			mul4096 = CLng(fin2048) * CLng(fin2048)
			fin4096 = mul4096 Mod modu.Text
			mul8192 = CLng(fin4096) * CLng(fin4096)
			fin8192 = mul8192 Mod modu.Text
			mul16384 = CLng(fin8192) * CLng(fin8192)
			fin16384 = mul16384 Mod modu.Text


			If thirtyonev = 1 Then
				thirtyonev = CLng(base.Text)
			Else
				thirtyonev = 1
			End If

			If thirtyv = 2 ^ 1 Then
				thirtyv = fin2
			Else
				thirtyv = 1
			End If

			If twentyninev = 2 ^ 2 Then
				twentyninev = fin4
			Else
				twentyninev = 1
			End If

			If twentyeightv = 2 ^ 3 Then
				twentyeightv = fin8
			Else
				twentyeightv = 1
			End If

			If twentysevenv = 2 ^ 4 Then
				twentysevenv = fin16
			Else
				twentysevenv = 1
			End If

			If twentysixv = 2 ^ 5 Then
				twentysixv = fin32
			Else
				twentysixv = 1
			End If

			If twentyfivev = 2 ^ 6 Then
				twentyfivev = fin64
			Else
				twentyfivev = 1
			End If

			If twentyfourv = 2 ^ 7 Then
				twentyfourv = fin128
			Else
				twentyfourv = 1
			End If

			If twentythreev = 2 ^ 8 Then
				twentythreev = fin256
			Else
				twentythreev = 1
			End If

			If twentytwov = 2 ^ 9 Then
				twentytwov = fin512
			Else
				twentytwov = 1
			End If

			If twentyonev = 2 ^ 10 Then
				twentyonev = fin1024
			Else
				twentyonev = 1
			End If

			If twentyv = 2 ^ 11 Then
				twentyv = fin2048
			Else
				twentyv = 1
			End If

			If nineteenv = 2 ^ 12 Then
				nineteenv = fin4096
			Else
				nineteenv = 1
			End If

			If eighteenv = 2 ^ 13 Then
				eighteenv = fin8192
			Else
				eighteenv = 1
			End If

			If seventeenv = 2 ^ 14 Then
				seventeenv = fin16384
			Else
				seventeenv = 1
			End If

			If sixteenv = 2 ^ 15 Then
				sixteenv = 1
				MsgBox("Exp. value too high!")
			Else
				sixteenv = 1
			End If

			If fifteenv = 2 ^ 16 Then
				fifteenv = 1
				MsgBox("Exp. value too high!")
			Else
				fifteenv = 1
			End If

			If fourteenv = 2 ^ 17 Then
				fourteenv = 1
				MsgBox("Exp. value too high!")
			Else
				fourteenv = 1
			End If

			If thirteenv = 2 ^ 18 Then
				thirteenv = 1
				MsgBox("Exp. value too high!")
			Else
				thirteenv = 1
			End If

			If twelvev = 2 ^ 19 Then
				twelvev = 1
				MsgBox("Exp. value too high!")
			Else
				twelvev = 1
			End If

			If elevenv = 2 ^ 20 Then
				elevenv = 1
				MsgBox("Exp. value too high!")
			Else
				elevenv = 1
			End If

			If tenv = 2 ^ 21 Then
				tenv = 1
				MsgBox("Exp. value too high!")
			Else
				tenv = 1
			End If

			If ninev = 2 ^ 22 Then
				ninev = 1
				MsgBox("Exp. value too high!")
			Else
				ninev = 1
			End If

			If eightv = 2 ^ 23 Then
				eightv = 1
				MsgBox("Exp. value too high!")
			Else
				eightv = 1
			End If

			If sevenv = 2 ^ 24 Then
				sevenv = 1
				MsgBox("Exp. value too high!")
			Else
				sevenv = 1
			End If

			If sixv = 2 ^ 25 Then
				sixv = 1
				MsgBox("Exp. value too high!")
			Else
				sixv = 1
			End If

			If fivev = 2 ^ 26 Then
				fivev = 1
				MsgBox("Exp. value too high!")
			Else
				fivev = 1
			End If

			If fourv = 2 ^ 27 Then
				fourv = 1
				MsgBox("Exp. value too high!")
			Else
				fourv = 1
			End If

			If threev = 2 ^ 28 Then
				threev = 1
				MsgBox("Exp. value too high!")
			Else
				threev = 1
			End If

			If twov = 2 ^ 29 Then
				twov = 1
				MsgBox("Exp. value too high!")
			Else
				twov = 1
			End If

			If onev = 2 ^ 30 Then
				onev = 1
				MsgBox("Exp. value too high!")
			Else
				onev = 1
			End If

			If zerov = 2 ^ 31 - 1 Then
				zerov = 1
				MsgBox("Exp. value too high!")
			Else
				zerov = 1
			End If

			fexp1 = ((zerov# Mod modu.Text) * (onev# Mod modu.Text)) Mod modu.Text
			fexp2 = ((twov# Mod modu.Text) * (threev# Mod modu.Text)) Mod modu.Text
			fexp3 = ((fourv# Mod modu.Text) * (fivev# Mod modu.Text)) Mod modu.Text
			fexp4 = ((sixv# Mod modu.Text) * (sevenv# Mod modu.Text)) Mod modu.Text
			fexp5 = ((eightv# Mod modu.Text) * (ninev# Mod modu.Text)) Mod modu.Text
			fexp6 = ((tenv# Mod modu.Text) * (elevenv# Mod modu.Text)) Mod modu.Text
			fexp7 = ((twelvev# Mod modu.Text) * (thirteenv# Mod modu.Text)) Mod modu.Text
			fexp8 = ((fourteenv# Mod modu.Text) * (fifteenv# Mod modu.Text)) Mod modu.Text
			fexp9 = ((sixteenv# Mod modu.Text) * (seventeenv# Mod modu.Text)) Mod modu.Text
			fexp10 = ((eighteenv# Mod modu.Text) * (nineteenv# Mod modu.Text)) Mod modu.Text
			fexp11 = ((twentyv# Mod modu.Text) * (twentyonev# Mod modu.Text)) Mod modu.Text
			fexp12 = ((twentytwov# Mod modu.Text) * (twentythreev# Mod modu.Text)) Mod modu.Text
			fexp13 = ((twentyfourv# Mod modu.Text) * (twentyfivev# Mod modu.Text)) Mod modu.Text
			fexp14 = ((twentysixv# Mod modu.Text) * (twentysevenv# Mod modu.Text)) Mod modu.Text
			fexp15 = ((twentyeightv# Mod modu.Text) * (twentyninev# Mod modu.Text)) Mod modu.Text
			fexp16 = ((thirtyv# Mod modu.Text) * (thirtyonev# Mod modu.Text)) Mod modu.Text

			ffexp1 = (fexp1# * fexp2#) Mod modu.Text
			ffexp2 = (fexp3# * fexp4#) Mod modu.Text
			ffexp3 = (fexp5# * fexp6#) Mod modu.Text
			ffexp4 = (fexp7# * fexp8#) Mod modu.Text
			ffexp5 = (fexp9# * fexp10#) Mod modu.Text
			ffexp6 = (fexp11# * fexp12#) Mod modu.Text
			ffexp7 = (fexp13# * fexp14#) Mod modu.Text
			ffexp8 = (fexp15# * fexp16#) Mod modu.Text

			fffexp1 = (ffexp1# * ffexp2#) Mod modu.Text
			fffexp2 = (ffexp3# * ffexp4#) Mod modu.Text
			fffexp3 = (ffexp5# * ffexp6#) Mod modu.Text
			fffexp4 = (ffexp7# * ffexp8#) Mod modu.Text

			ffffexp1 = (fffexp1# * fffexp2#) Mod modu.Text
			ffffexp2 = (fffexp3# * fffexp4#) Mod modu.Text

			fffexp = (ffffexp1 * ffffexp2) Mod modu.Text

			fexp = fffexp

			dexp = fexp Mod modu.Text
			res.Text = dexp
		End If

	End Sub
End Class