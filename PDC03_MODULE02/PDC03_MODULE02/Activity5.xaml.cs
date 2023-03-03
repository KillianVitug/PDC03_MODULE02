using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE02
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Activity5 : ContentPage
	{
		ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
		public ObservableCollection<Employee> Employees { get { return employees; } }

		public Activity5 ()
		{
			InitializeComponent ();

			{
				lst.ItemsSource = employees;

				employees.Add(new Employee { DisplayName = "Juan Dela Cruz", Position = "President", profileImage = "image1.jfif" });
                employees.Add(new Employee { DisplayName = "Jarel", Position = "Vice President", profileImage = "image2.jpg" });
                employees.Add(new Employee { DisplayName = "Killian", Position = "Secretary", profileImage = "https://i.natgeofe.com/n/bb13f61c-edaa-4ad9-8230-879a2d2d1ad4/6924567_2x1.jpg" });
            }
		}
	}
}