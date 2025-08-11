Public Class frmPredpregled
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents crPregledovalnik As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPredpregled))
        Me.crPregledovalnik = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crPregledovalnik
        '
        Me.crPregledovalnik.ActiveViewIndex = -1
        Me.crPregledovalnik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crPregledovalnik.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.crPregledovalnik.DisplayBackgroundEdge = False
        Me.crPregledovalnik.DisplayGroupTree = False
        Me.crPregledovalnik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crPregledovalnik.Location = New System.Drawing.Point(0, 0)
        Me.crPregledovalnik.Name = "crPregledovalnik"
        Me.crPregledovalnik.SelectionFormula = ""
        Me.crPregledovalnik.Size = New System.Drawing.Size(804, 585)
        Me.crPregledovalnik.TabIndex = 0
        Me.crPregledovalnik.ViewTimeSelectionFormula = ""
        '
        'frmPredpregled
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 585)
        Me.Controls.Add(Me.crPregledovalnik)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPredpregled"
        Me.Text = "Predpregled"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPredpregled_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ------ Podstavljanje data seta kar report-u; DELA, èe je report design-iran na data set-u
        'Dim objdbZaposleni As dbZaposleni = New dbZaposleni
        'Dim ds As DataSet
        'Dim objReport As rptZaposleniSeznam = New rptZaposleniSeznam
        'ds = objdbZaposleni.Najdi
        'objReport.SetDataSource(ds)
        'objReport.SetDataSource(ds.Tables(0)) 'dela tudi tako
        'crPregledovalnik.ReportSource = objReport

        ' ------ Podstavljanje dataview-a kar report-u; osnova je .txt datoteka
        'Dim objdbZaposleni As dbZaposleni = New dbZaposleni
        'Dim ds As DataSet
        'Dim objReport As rptZaposleniSeznam = New rptZaposleniSeznam
        'ds = objdbZaposleni.Najdi
        'objReport.SetDataSource(ds) 'tako se ne da povezat na .txt datoteko
        'objReport.SetDataSource(ds.Tables(0)) 'tako lahko povežem na .txt datoteko
        'crPregledovalnik.ReportSource = objReport

        ' ------ Podstavljanje data seta ReportDocument-u; DELA, èe je report design-iran na data set-u
        'Dim objdbZaposleni As dbZaposleni = New dbZaposleni
        'Dim ds As DataSet
        'ds = objdbZaposleni.Najdi
        'RepDOK.SetDataSource(ds)
        'crPregledovalnik.ReportSource = RepDOK

        ' ------ Podstavljanje data seta ReportDocument-u preko Data seta,
        ' ------ ki je kreiran na formi; DELA
        'sdaZaposleni.Fill(ndsZaposleni)
        'RepDOK.SetDataSource(ndsZaposleni)
        'crPregledovalnik.ReportSource = RepDOK

        AddHandler crPregledovalnik.DrillDownSubreport, AddressOf CrystalReportViewer1_DrillDownSubreport

    End Sub

    Private Sub crPregledovalnik_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles crPregledovalnik.Click

    End Sub

    Private Sub crPregledovalnik_Drill(ByVal source As Object, ByVal e As CrystalDecisions.Windows.Forms.DrillEventArgs) Handles crPregledovalnik.Drill

    End Sub

    Private Sub CrystalReportViewer1_DrillDownSubreport(ByVal source As Object, ByVal e As CrystalDecisions.Windows.Forms.DrillSubreportEventArgs) Handles crPregledovalnik.DrillDownSubreport
        'MsgBox("keks")
        Dim p As Point = New Point(e.NewSubreportPosition.X, e.NewSubreportPosition.Y)

        'crPregledovalnik.ReportSource.ToString()
    End Sub

    Private Sub crPregledovalnik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crPregledovalnik.Load

    End Sub
End Class
