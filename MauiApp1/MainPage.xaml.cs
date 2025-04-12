namespace MauiApp1;
using System.Text.RegularExpressions;

public partial class MainPage : ContentPage
{
	// int count = 0;
	private bool IsPasswordValid(string pass1, string pass2) {
		// Esta funcion revisara si las contraseñas no estan vacias, si son 
		// iguales y si cumplen con el patron REGEX valido. 

		// check if any is empty or null
		if (string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2)) {
			return false;
		}
		// check if is the same pass 1 and pass2
		if (pass1 != pass2) {
			return false;
		}
		var pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d]).+$";
		return Regex.IsMatch(pass1, pattern);
	}

	public MainPage() {
		InitializeComponent();
	}

	private void OnSubmitClicked(object sender, EventArgs e) {
		// Funcion que sera ejecutada una vez demos click en el boton 
		// para validar el password
		// Get the text from the Entry field
		string inputPass = entPass1.Text;
		string repeatPass = entPass2.Text;

		// if IsPasswordValid is  false show alert with message "Password is not valid"
		if (!IsPasswordValid(inputPass, repeatPass)) {
			DisplayAlert("Validación de password", "Password is not valid", "OK");
			return;
		} else {
			// show alert with message "Password is valid"
			DisplayAlert("Validación de password", "Password is valid", "OK");
		}
	}
}

