<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.carte = New AxMapWinGIS.AxMap()
        Me.btn_add_data = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_pan = New System.Windows.Forms.RadioButton()
        Me.rd_zoom_arrier = New System.Windows.Forms.RadioButton()
        Me.rd_zoom_avant = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.carte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'carte
        '
        Me.carte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.carte.Enabled = True
        Me.carte.Location = New System.Drawing.Point(47, 21)
        Me.carte.Name = "carte"
        Me.carte.OcxState = CType(resources.GetObject("carte.OcxState"), System.Windows.Forms.AxHost.State)
        Me.carte.Size = New System.Drawing.Size(589, 389)
        Me.carte.TabIndex = 0
        '
        'btn_add_data
        '
        Me.btn_add_data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_add_data.Location = New System.Drawing.Point(95, 442)
        Me.btn_add_data.Name = "btn_add_data"
        Me.btn_add_data.Size = New System.Drawing.Size(116, 27)
        Me.btn_add_data.TabIndex = 1
        Me.btn_add_data.Text = "Ajouter des données"
        Me.btn_add_data.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rd_pan)
        Me.GroupBox1.Controls.Add(Me.rd_zoom_arrier)
        Me.GroupBox1.Controls.Add(Me.rd_zoom_avant)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 442)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 45)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode curseur de souris"
        '
        'rd_pan
        '
        Me.rd_pan.AutoSize = True
        Me.rd_pan.Location = New System.Drawing.Point(213, 22)
        Me.rd_pan.Name = "rd_pan"
        Me.rd_pan.Size = New System.Drawing.Size(82, 17)
        Me.rd_pan.TabIndex = 0
        Me.rd_pan.Text = "Se déplacer"
        Me.rd_pan.UseVisualStyleBackColor = True
        '
        'rd_zoom_arrier
        '
        Me.rd_zoom_arrier.AutoSize = True
        Me.rd_zoom_arrier.Location = New System.Drawing.Point(117, 22)
        Me.rd_zoom_arrier.Name = "rd_zoom_arrier"
        Me.rd_zoom_arrier.Size = New System.Drawing.Size(84, 17)
        Me.rd_zoom_arrier.TabIndex = 0
        Me.rd_zoom_arrier.Text = "Zoom arriére"
        Me.rd_zoom_arrier.UseVisualStyleBackColor = True
        '
        'rd_zoom_avant
        '
        Me.rd_zoom_avant.AutoSize = True
        Me.rd_zoom_avant.Checked = True
        Me.rd_zoom_avant.Location = New System.Drawing.Point(21, 22)
        Me.rd_zoom_avant.Name = "rd_zoom_avant"
        Me.rd_zoom_avant.Size = New System.Drawing.Size(82, 17)
        Me.rd_zoom_avant.TabIndex = 0
        Me.rd_zoom_avant.TabStop = True
        Me.rd_zoom_avant.Text = "Zoom avant"
        Me.rd_zoom_avant.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TrackBar3)
        Me.GroupBox2.Controls.Add(Me.TrackBar2)
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(684, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 213)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Palette de couleurs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "B"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(37, 19)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(213, 45)
        Me.TrackBar1.TabIndex = 5
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(37, 70)
        Me.TrackBar2.Maximum = 255
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(213, 45)
        Me.TrackBar2.TabIndex = 5
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(37, 121)
        Me.TrackBar3.Maximum = 255
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(213, 45)
        Me.TrackBar3.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 499)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_add_data)
        Me.Controls.Add(Me.carte)
        Me.Name = "Form1"
        Me.Text = "Visionnaire de données"
        CType(Me.carte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents carte As AxMapWinGIS.AxMap
    Friend WithEvents btn_add_data As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rd_pan As System.Windows.Forms.RadioButton
    Friend WithEvents rd_zoom_arrier As System.Windows.Forms.RadioButton
    Friend WithEvents rd_zoom_avant As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBar3 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
