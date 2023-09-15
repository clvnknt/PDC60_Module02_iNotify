using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PDC60Module02.Model;
using Xamarin.Forms;

namespace PDC60Module02.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }
        public Command SubmitEntry {  get; set; }

        public Command ClearEntry { get; set; }

        public string SubjectCodeEntry { get; set; }
        public string SubjectCodeDisplay { get; set; }

        public string SubjectTitleEntry { get; set; }
        public string SubjectTitleDisplay { get; set; }

        public string SubjectUnitEntry { get; set; }
        public string SubjectUnitDisplay { get; set; }

        public StudentViewModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student
                {
                    SubjectCode = SubjectCodeEntry,
                };

                SubjectCodeDisplay = SubjectCodeEntry;
                SubjectTitleDisplay = SubjectTitleEntry;
                SubjectUnitDisplay = SubjectUnitEntry;

                onPropertyChanged(nameof(SubjectCodeDisplay));
                onPropertyChanged(nameof(SubjectCodeEntry));

                onPropertyChanged(nameof(SubjectTitleDisplay));
                onPropertyChanged(nameof(SubjectTitleEntry));

                onPropertyChanged(nameof(SubjectUnitDisplay));
                onPropertyChanged(nameof(SubjectUnitEntry));
            });

            ClearEntry = new Command(() =>
            {
                StudentSet = new Student
                {
                    SubjectCode = SubjectCodeEntry,
                };

                SubjectCodeEntry = "";
                SubjectTitleEntry = "";
                SubjectUnitEntry = "";
                SubjectCodeDisplay = "";
                SubjectTitleDisplay = "";
                SubjectUnitDisplay = "";

                onPropertyChanged(nameof(SubjectCodeDisplay));
                onPropertyChanged(nameof(SubjectCodeEntry));

                onPropertyChanged(nameof(SubjectTitleDisplay));
                onPropertyChanged(nameof(SubjectTitleEntry));

                onPropertyChanged(nameof(SubjectUnitDisplay));
                onPropertyChanged(nameof(SubjectUnitEntry));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void onPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}