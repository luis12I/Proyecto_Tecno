<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_pais = New System.Windows.Forms.TextBox()
        Me.txt_ocupacion = New System.Windows.Forms.TextBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lbl_administrador = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pais"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ocupacion"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(127, 30)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 5
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(127, 59)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(127, 90)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(100, 20)
        Me.txt_correo.TabIndex = 7
        '
        'txt_pais
        '
        Me.txt_pais.Location = New System.Drawing.Point(127, 117)
        Me.txt_pais.Name = "txt_pais"
        Me.txt_pais.Size = New System.Drawing.Size(100, 20)
        Me.txt_pais.TabIndex = 8
        '
        'txt_ocupacion
        '
        Me.txt_ocupacion.Location = New System.Drawing.Point(127, 145)
        Me.txt_ocupacion.Name = "txt_ocupacion"
        Me.txt_ocupacion.Size = New System.Drawing.Size(100, 20)
        Me.txt_ocupacion.TabIndex = 9
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(12, 203)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(75, 23)
        Me.btn_insertar.TabIndex = 10
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(93, 203)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cargar.TabIndex = 11
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_borrar.Location = New System.Drawing.Point(174, 203)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 12
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(12, 245)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 23)
        Me.btn_editar.TabIndex = 13
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(255, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(285, 153)
        Me.DGV.TabIndex = 14
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(93, 245)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 15
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lbl_administrador
        '
        Me.lbl_administrador.AutoSize = True
        Me.lbl_administrador.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_administrador.Location = New System.Drawing.Point(273, 200)
        Me.lbl_administrador.Name = "lbl_administrador"
        Me.lbl_administrador.Size = New System.Drawing.Size(252, 26)
        Me.lbl_administrador.TabIndex = 17
        Me.lbl_administrador.Text = "Bienvenido Administrador"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_cerrar.Location = New System.Drawing.Point(489, 241)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(51, 23)
        Me.btn_cerrar.TabIndex = 18
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(552, 276)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lbl_administrador)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.txt_ocupacion)
        Me.Controls.Add(Me.txt_pais)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_pais As TextBox
    Friend WithEvents txt_ocupacion As TextBox
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_cargar As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_administrador As Label
    Friend WithEvents btn_cerrar As Button
End Class
