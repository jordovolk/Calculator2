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
        Grid layout;
        Button bNegative;
        Button b0;
        Button b1;
        Button b2;
        Button b3;
        Button b4;
        Button b5;
        Button b6;
        Button b7;
        Button b8;
        Button b9;
        Button bAdd;
        Button bSubtract;
        Button bMultiply;
        Button bDivide;
        Button bClear;
        Button bEquals;
        Button bstyle1;
        Button bstyle2;
        Boolean style1;
        Boolean style2;
        
       



        public Calculator()

        {

            Resources = new ResourceDictionary {
      {
          "buttonStyle1",
          new Style(typeof(Button)) {
              Setters = {
                  new Setter {
                      Property = View.HorizontalOptionsProperty,
                          Value = LayoutOptions.Center
                  },
                  new Setter {
                      Property = View.VerticalOptionsProperty,
                          Value = LayoutOptions.CenterAndExpand
                  },
                  new Setter {
                      Property = Button.BorderWidthProperty,
                          Value = 3
                  },
                  new Setter {
                      Property = Button.TextColorProperty,
                          Value = Color.Red
                  },
                  new Setter {
                      Property = Button.FontSizeProperty,
                          Value = Device.GetNamedSize(NamedSize.Large, typeof(Button))
                  },
                  new Setter {
                      Property = VisualElement.BackgroundColorProperty,
                          Value = Device.OnPlatform(Color.Default,
                              Color.FromRgb(0x40, 0x40, 0x40),

                              Color.Default)
                  },
                  new Setter {
                      Property = Button.BorderColorProperty,
                          Value = Device.OnPlatform(Color.Default,
                              Color.White,
                              Color.Black)
                  }
              }
          }
      },

                {
             "buttonStyle2",
          new Style(typeof(Button))
          {
              Setters = {
                  new Setter {
                      Property = View.HorizontalOptionsProperty,
                          Value = LayoutOptions.Center
                  },
                  new Setter {
                      Property = View.VerticalOptionsProperty,
                          Value = LayoutOptions.CenterAndExpand
                  },
                  new Setter {
                      Property = Button.BorderWidthProperty,
                          Value = 3
                  },
                  new Setter {
                      Property = Button.TextColorProperty,
                          Value = Color.Blue
                  },
                  new Setter {
                      Property = Button.FontSizeProperty,
                          Value = Device.GetNamedSize(NamedSize.Large, typeof(Button))
                  },
                  new Setter {
                      Property = VisualElement.BackgroundColorProperty,
                          Value = Device.OnPlatform(Color.Default,
                              Color.FromRgb(0x40, 0x40, 0x40),

                              Color.Default)
                  },
                  new Setter {
                      Property = Button.BorderColorProperty,
                          Value = Device.OnPlatform(Color.Default,
                              Color.White,
                              Color.Black)
                  }
              }
          }
      }
                };


        //


        //

        layout = new Grid();

            layout.VerticalOptions = LayoutOptions.CenterAndExpand;
            layout.HorizontalOptions = LayoutOptions.CenterAndExpand;



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


           











             b0 = new Button { Text = "0", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center};

            

             b1 = new Button { Text = "1", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b2 = new Button { Text = "2", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b3 = new Button { Text = "3", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b4 = new Button { Text = "4", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b5 = new Button { Text = "5", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b6 = new Button { Text = "6", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b7 = new Button { Text = "7", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b8 = new Button { Text = "8", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             b9 = new Button { Text = "9", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             bMultiply = new Button { Text = "X", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             bDivide = new Button { Text = "/", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             bAdd = new Button { Text = "+", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             bSubtract = new Button { Text = "-", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             bClear = new Button { Text = "C", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

             bEquals = new Button { Text = "=", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };

            bNegative = new Button { Text = "NEG", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center, FontSize = 12 };

             bstyle1 = new Button { Text = "Change Style", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center, FontSize = 12 };

             bstyle2 = new Button { Text = "Style 2", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.Center };


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

            //style 1 button
            Grid.SetColumn(bstyle1, 2);
            Grid.SetRow(bstyle1, 0);
            Grid.SetColumn(bstyle2, 1);
            Grid.SetRow(bstyle2, 0);
            




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
            layout.Children.Add(bstyle1);
            //layout.Children.Add(bstyle2);



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

            bstyle1.Clicked += OnStyle1ButtonClicked;

            bNegative.IsEnabled = true;

            changetoStyle1();



            












        }

        void changetoStyle1()
        {
            bNegative.Style = (Style)Resources["buttonStyle1"];
            bClear.Style = (Style)Resources["buttonStyle1"];
            bEquals.Style = (Style)Resources["buttonStyle1"];
            bAdd.Style = (Style)Resources["buttonStyle1"];
            bSubtract.Style = (Style)Resources["buttonStyle1"];
            bMultiply.Style = (Style)Resources["buttonStyle1"];
            bDivide.Style = (Style)Resources["buttonStyle1"];
            b0.Style = (Style)Resources["buttonStyle1"];
            b1.Style = (Style)Resources["buttonStyle1"];
            b2.Style = (Style)Resources["buttonStyle1"];
            b3.Style = (Style)Resources["buttonStyle1"];
            b4.Style = (Style)Resources["buttonStyle1"];
            b5.Style = (Style)Resources["buttonStyle1"];
            b6.Style = (Style)Resources["buttonStyle1"];
            b7.Style = (Style)Resources["buttonStyle1"];
            b8.Style = (Style)Resources["buttonStyle1"];
            b9.Style = (Style)Resources["buttonStyle1"];
            bstyle1.Style = (Style)Resources["buttonStyle1"];
            style1 = true;
            style2 = false;
        }

        void changetoStyle2()
        {
            bNegative.Style = (Style)Resources["buttonStyle2"];
            bClear.Style = (Style)Resources["buttonStyle2"];
            bEquals.Style = (Style)Resources["buttonStyle2"];
            bAdd.Style = (Style)Resources["buttonStyle2"];
            bSubtract.Style = (Style)Resources["buttonStyle2"];
            bMultiply.Style = (Style)Resources["buttonStyle2"];
            bDivide.Style = (Style)Resources["buttonStyle2"];
            b0.Style = (Style)Resources["buttonStyle2"];
            b1.Style = (Style)Resources["buttonStyle2"];
            b2.Style = (Style)Resources["buttonStyle2"];
            b3.Style = (Style)Resources["buttonStyle2"];
            b4.Style = (Style)Resources["buttonStyle2"];
            b5.Style = (Style)Resources["buttonStyle2"];
            b6.Style = (Style)Resources["buttonStyle2"];
            b7.Style = (Style)Resources["buttonStyle2"];
            b8.Style = (Style)Resources["buttonStyle2"];
            b9.Style = (Style)Resources["buttonStyle2"];
            bstyle1.Style = (Style)Resources["buttonStyle2"];
            style1 = false; 
            style2 = true;
        }


        void OnStyle1ButtonClicked(object sender, EventArgs e)
        {
            if (style1 == true)
            {
                changetoStyle2();
            }
            else
            {
                changetoStyle1();
            }

            

            





        }

        void OnStyle2ButtonClicked(object sender, EventArgs e)
        {

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
