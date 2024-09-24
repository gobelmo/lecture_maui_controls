namespace MauiControls;

public partial class IniCommand : ContentPage
{
	public IniCommand()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Alert title", "Alert message", "OK");
	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Alert title", "Alert message from image button click", "OK");
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		var radioButton = (RadioButton)sender;
		if (radioButton.IsChecked)
		{
			SelectedGradeLabel.Text = radioButton.Value.ToString();
		}
	}

}