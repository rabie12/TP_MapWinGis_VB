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
        CType(Me.carte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'carte
        '
        Me.carte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.carte.Enabled = True
        Me.carte.Location = New System.Drawing.Point(47, 21)
        Me.carte.Name = "carte"
        Me.carte.OcxState = CType(resources.GetObject("carte.OcxState"), System.Windows.Forms.AxHost.State)
        Me.carte.Size = New System.Drawing.Size(554, 356)
        Me.carte.TabIndex = 0
        '
        'btn_add_data
        '
        Me.btn_add_data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_add_data.Location = New System.Drawing.Point(95, 409)
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
        Me.GroupBox1.Location = New System.Drawing.Point(264, 409)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 466)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_add_data)
        Me.Controls.Add(Me.carte)
        Me.Name = "Form1"
        Me.Text = "Visionnaire de données"
        CType(Me.carte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents carte As AxMapWinGIS.AxMap
    Friend WithEvents btn_add_data As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rd_pan As System.Windows.Forms.RadioButton
    Friend WithEvents rd_zoom_arrier As System.Windows.Forms.RadioButton
    Friend WithEvents rd_zoom_avant As System.Windows.Forms.RadioButton

End Class
