﻿namespace DG_AppApuntesMVVM;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(DG_Views.DG_Notas), typeof(DG_Views.DG_Notas));
    }
}
