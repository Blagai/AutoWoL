namespace AutoWoL;

public partial class ComputerPage : ContentPage
{
	string _FileName = Path.Combine(FileSystem.AppDataDirectory, "Computers");

	public ComputerPage()
	{
		InitializeComponent();

		if (File.Exists(_FileName))
		{
			// Code to load the data
			// Should create a new element for each line, as each line is another WoL device
		}
	}

	private void SaveClicked(object sender, EventArgs e)
	{
		string Hostname = HostnameEditor.Text;
		string Mac = MacEditor.Text;

		string FormattedInfo = $"{Hostname}, {Mac}";

		File.AppendAllText(_FileName, FormattedInfo + Environment.NewLine);
	}

	private void DeleteClicked(object sender, EventArgs e)
	{
		string MacDelete= MacEditor.Text;
		var Lines = File.ReadAllLines(_FileName).ToList();
		var LineToDelete = Lines.FirstOrDefault(line => line.Contains(MacDelete, StringComparison.OrdinalIgnoreCase));

		if (LineToDelete != null)
		{
			File.AppendAllText(_FileName, LineToDelete + Environment.NewLine);
			Lines.Remove(LineToDelete);
			File.WriteAllLines(_FileName, Lines);
		}

    }
}