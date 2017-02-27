using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator2
{

    class Calculator : ContentPage
    {
        Label displayLabel;
        float num1, ans;
        int count;
        Int32 negativevalueassigned = 0;
        
       



        public Calculator()

        {

            var layout = new Grid();



            // Rows:

            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });

            layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });



            // Columns:

            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var relativeLayout = new RelativeLayout();
            relativeLayout.Children.Add(layout, // <= Original layout
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent(p => p.Width),
                Constraint.RelativeToParent(p => p.Height));
            Content = relativeLayout;







            displayLabel = new Label { Text = "" };


           











            var b0 = new Button { Text = "0" };

            var b1 = new Button { Text = "1" };

            var b2 = new Button { Text = "2" };

            var b3 = new Button { Text = "3" };

            var b4 = new Button { Text = "4" };

            var b5 = new Button { Text = "5" };

            var b6 = new Button { Text = "6" };

            var b7 = new Button { Text = "7" };

            var b8 = new Button { Text = "8" };

            var b9 = new Button { Text = "9" };

            var bMultiply = new Button { Text = "X" };

            var bDivide = new Button { Text = "/" };

            var bAdd = new Button { Text = "+" };

            var bSubtract = new Button { Text = "-" };

            var bClear = new Button { Text = "C" };

            var bEquals = new Button { Text = "=" };

            var bNegative = new Button { Text = "NEG" };



            //output

            Grid.SetColumn(displayLabel, 1);

            Grid.SetRow(displayLabel, 0);

            Grid.SetColumnSpan(displayLabel, 4);
            Grid.SetColumn(bNegative, 3);

            Grid.SetRow(bNegative, 0);

            //buttons

            Grid.SetColumn(b0, 1);

            Grid.SetColumn(b1, 2);

            Grid.SetColumn(b2, 3);

            Grid.SetColumn(b3, 1);

            Grid.SetColumn(b4, 2);

            Grid.SetColumn(b5, 3);

            Grid.SetColumn(b6, 1);

            Grid.SetColumn(b7, 2);

            Grid.SetColumn(b8, 3);

            Grid.SetColumn(b9, 1);

            Grid.SetColumn(bEquals, 2);

            Grid.SetColumn(bClear, 3);
            




            Grid.SetColumn(bAdd, 0);

            Grid.SetColumn(bSubtract, 0);

            Grid.SetColumn(bDivide, 0);

            Grid.SetColumn(bMultiply, 0);







            Grid.SetRow(b0, 4);

            Grid.SetRow(b1, 4);

            Grid.SetRow(b2, 4);

            Grid.SetRow(b3, 3);

            Grid.SetRow(b4, 3);

            Grid.SetRow(b5, 3);

            Grid.SetRow(b6, 2);

            Grid.SetRow(b7, 2);

            Grid.SetRow(b8, 2);

            Grid.SetRow(b9, 1);

            Grid.SetRow(bEquals, 1);

            Grid.SetRow(bClear, 1);

            Grid.SetRow(bAdd, 1);

            Grid.SetRow(bSubtract, 2);

            Grid.SetRow(bDivide, 3);

            Grid.SetRow(bMultiply, 4);







            layout.Children.Add(b0);

            layout.Children.Add(b1);

            layout.Children.Add(b2);

            layout.Children.Add(b3);

            layout.Children.Add(b4);

            layout.Children.Add(b5);

            layout.Children.Add(b6);

            layout.Children.Add(b7);

            layout.Children.Add(b8);

            layout.Children.Add(b9);

            layout.Children.Add(displayLabel);

            layout.Children.Add(bClear);

            layout.Children.Add(bEquals);

            layout.Children.Add(bAdd);

            layout.Children.Add(bSubtract);

            layout.Children.Add(bDivide);

            layout.Children.Add(bMultiply);
            layout.Children.Add(bNegative);



            //event handlers

            b0.Clicked += OnB0Clicked;

            b1.Clicked += OnB1Clicked;

            b2.Clicked += OnB2Clicked;

            b3.Clicked += OnB3Clicked;

            b4.Clicked += OnB4Clicked;

            b5.Clicked += OnB5Clicked;

            b6.Clicked += OnB6Clicked;

            b7.Clicked += OnB7Clicked;

            b8.Clicked += OnB8Clicked;

            b9.Clicked += OnB9Clicked;

            bEquals.Clicked += OnEqualButtonClicked;

            bClear.Clicked += OnClearButtonClicked;

            bAdd.Clicked += OnAddButtonClicked;

            bSubtract.Clicked += OnSubtractButtonClicked;

            bDivide.Clicked += OnDivideButtonClicked;

            bMultiply.Clicked += OnMultiplyButtonClicked;

            bNegative.Clicked += OnNegativeButtonClicked;

            bNegative.IsEnabled = true;






          





        }

        void OnNegativeButtonClicked(object sender, EventArgs e)
        {
            Button buttonClickedOn = (Button)sender;
            String firstChar = displayLabel.Text.Substring(0);

            if (displayLabel.Text != "")
            {
                displayLabel.Text = "-" + displayLabel.Text;
                negativevalueassigned += 1;
                
            }

           
          
        }


        void OnB0Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 0;

        }

        void OnB1Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 1;

        }

        void OnB2Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 2;

        }

        void OnB3Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 3;

        }

        void OnB4Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 4;

        }

        void OnB5Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 5;

        }

        void OnB6Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 6;

        }

        void OnB7Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 7;

        }

        void OnB8Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 8;

        }

        void OnB9Clicked(object sender, EventArgs e)
        {
            displayLabel.Text = displayLabel.Text + 9;

        }










        void OnClearButtonClicked(object sender, EventArgs e)

        {



            displayLabel.Text = "";
            count = 0;
            negativevalueassigned = 0;


        }



        void OnAddButtonClicked(object sender, EventArgs e)

        {
            if (negativevalueassigned > 1)
            {
                displayLabel.Text = "not valid";
            }
           else if (displayLabel.Text != "")
            {
                num1 = float.Parse(displayLabel.Text);
                displayLabel.Text = "";
                displayLabel.Focus();
                count = 2;
            }
            
}



        void OnSubtractButtonClicked(object sender, EventArgs e)

        {
            if (negativevalueassigned > 1)
            {
                displayLabel.Text = "not valid";
            }

            else if (displayLabel.Text != "")
            {
                num1 = float.Parse(displayLabel.Text);
                
                displayLabel.Text = "";
                displayLabel.Focus();
                count = 1;
            }

            

            //Button buttonClickedOn = (Button)sender;



            //displayLabel.Text += (string)buttonClickedOn.Text;
}



        void OnMultiplyButtonClicked(object sender, EventArgs e)

        {
            if (negativevalueassigned > 1)
            {
                displayLabel.Text = "not valid";
            }

            else if (displayLabel.Text != "")
            {
                num1 = float.Parse(displayLabel.Text);
                displayLabel.Text = "";
                displayLabel.Focus();
                count = 3;
            }




        }



        void OnDivideButtonClicked(object sender, EventArgs e)

        {
            if (negativevalueassigned > 1)
            {
                displayLabel.Text = "not valid";
            }

            else if (displayLabel.Text != "")
            {
                num1 = float.Parse(displayLabel.Text);
                displayLabel.Text = "";
                displayLabel.Focus();
                count = 4;
            }
        }



        void OnEqualButtonClicked(object sender, EventArgs e)

        {
            if(negativevalueassigned > 2)
            {
                displayLabel.Text = "not valid";
            }
          
            else
            {
                compute(count);
            }
            

        }

        public void compute(int count)
        {
            switch(count) {
                case 1:
                    ans = num1 - float.Parse(displayLabel.Text);
                    displayLabel.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(displayLabel.Text);
                    displayLabel.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(displayLabel.Text);
                    displayLabel.Text = ans.ToString();
                    break;
                case 4:
                    
                    ans = num1 / float.Parse(displayLabel.Text);
                    displayLabel.Text = ans.ToString();
                        break;
                    
                default:
                    break;



            }
        }
    }
}
