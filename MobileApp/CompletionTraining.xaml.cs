using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CompletionTraining : ContentPage
	{
		public CompletionTraining()
		{
			InitializeComponent();
		}

		private async void EndTraining(object sender, EventArgs e)
		{
			App.Db.UpdateCurDate();
            await Navigation.PushAsync(new ProgramNow());
		}
	}
}