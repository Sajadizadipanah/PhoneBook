namespace MyApplication;

internal static class Program
{
	static Program()
	{
	}

	[System.STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		
		var mainForm = new PhoneBookForm();

		Application.Run(mainForm: mainForm);

		if (mainForm != null)
		{
			if (mainForm.IsDisposed == false)
			{
				mainForm.Dispose();
			}

			mainForm = null;
		}
		// **************************************************
	}
}
