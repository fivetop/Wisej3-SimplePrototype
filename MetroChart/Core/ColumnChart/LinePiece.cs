namespace MetroChart
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Windows;  
    using System.Reflection;
    using System.Collections.Specialized;
    using System.Windows.Input;
    using System.Windows.Controls;

#if NETFX_CORE
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media;
    using Windows.UI.Xaml.Shapes;
    using Windows.UI.Xaml.Markup;
    using Windows.UI.Xaml;
    using Windows.Foundation;
    using Windows.UI;
    using Windows.UI.Xaml.Media.Animation;
    using Windows.UI.Core;
#else
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;
    
#endif

    public class LinePiece : PieceBase
    {
        #region Fields

        private Border slice = null;

        public static readonly DependencyProperty PercentageProperty =
            DependencyProperty.Register("Percentage", typeof(double), typeof(LinePiece),
            new PropertyMetadata(0.0, new PropertyChangedCallback(OnPercentageChanged)));
        
        public static readonly DependencyProperty ColumnHeightProperty =
            DependencyProperty.Register("ColumnHeight", typeof(double), typeof(LinePiece),
            new PropertyMetadata(0.0));

        public double sHeight { get; set; }

        #endregion Fields

        #region Constructors

        static LinePiece()        
        {
#if NETFX_CORE
                        
#elif SILVERLIGHT
    
#else
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LinePiece), new FrameworkPropertyMetadata(typeof(LinePiece)));
#endif
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinePiece"/> class.
        /// </summary>
        public LinePiece()
        {
#if NETFX_CORE
            this.DefaultStyleKey = typeof(LinePiece);
#endif
#if SILVERLIGHT
            this.DefaultStyleKey = typeof(LinePiece);
#endif
            Loaded += LinePiece_Loaded;
        }

        #endregion Constructors

        #region Properties

        public double Percentage
        {
            get { return (double)GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty, value); }
        }

        public double ColumnHeight
        {
            get { return (double)GetValue(ColumnHeightProperty); }
            set { SetValue(ColumnHeightProperty, value); }
        }
 
        #endregion Properties

        #region Methods

        private static void OnPercentageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as LinePiece).DrawGeometry();
        }


        protected override void InternalOnApplyTemplate()
        {
            slice = this.GetTemplateChild("Slice") as Border;
            RegisterMouseEvents(slice);
        }

        void LinePiece_Loaded(object sender, RoutedEventArgs e)
        {
            DrawGeometry();
        }

        protected override void DrawGeometry(bool withAnimation = true)
        {    
            try
            {
                if (this.ClientWidth <= 0.0)
                {
                    return;
                }
                if (this.ClientHeight <= 0.0)
                {
                    return;
                }

                double startHeight = 0;
                double sh = this.ClientHeight * Percentage;

                if (slice.Height > 0)
                {
                    startHeight = slice.Height;
                }
                
                if (sh > 0)
                {
                    sHeight = sh;

                    EvenlyDistributedColumnsGrid a1 = FindVisualParentByName<EvenlyDistributedColumnsGrid>(this, "ePanelRomee");
                    EvenlyDistributedColumnsGrid a2 = FindVisualParentByName<EvenlyDistributedColumnsGrid>(this, "ePanelRomee1");

                    int col = 0;
                    foreach (ContentPresenter t1 in a1.Children)
                    {
                        if (t1.DataContext.Equals(a2.DataContext))
                        {
                            List<Lineadd> p1 = a1._lineadd;

                            if (col == 0)
                            {
                                p1[col].y1 = this.ClientHeight - sHeight;
                                p1[col].y2 = this.ClientHeight - sHeight;
                                break;
                            }
                            else
                            {
                                Lineadd b = p1[col - 1];
                                p1[col].y1 = b.y2;
                                p1[col].y2 = this.ClientHeight - sHeight;
                                break;
                            }
                        }
                        col++;
                    }
                    if (col > 8)
                    {
                        // 그리기 처리 
                        Grid g1 = FindVisualParentByName<Grid>(this, "_gridAAA1");
                        Grid g2 = (Grid)g1.Children[1];
                        List<Lineadd> p1 = a1._lineadd;

                        if (p1[0].y1 != 0)
                        {
                            g2.Children.Clear();

                            for (int i = 1; i < 10; i++)
                            {
                                Lineadd b = p1[i - 1];
                                p1[i].y1 = b.y2;
                                // Console.WriteLine("Size : {0} , {1}", i, b.y2);
                            }

                            for (int i = 0; i < 10; i++)
                            {
                                Line l1 = new Line();
                                l1.X1 = p1[i].x1;
                                l1.Y1 = p1[i].y1;
                                l1.X2 = p1[i].x2;
                                l1.Y2 = p1[i].y2;
                                l1.StrokeThickness = 3;
                                l1.Stroke = Brushes.MediumVioletRed;
                                g2.Children.Add(l1);
                            }
                        }
                    }
                }

                DoubleAnimation scaleAnimation = new DoubleAnimation();
                scaleAnimation.From = startHeight;
                scaleAnimation.To = this.ClientHeight * Percentage;
                scaleAnimation.Duration = TimeSpan.FromMilliseconds(withAnimation ? 500: 0);
                scaleAnimation.EasingFunction = new QuarticEase() { EasingMode = EasingMode.EaseOut };
                Storyboard storyScaleX = new Storyboard();
                storyScaleX.Children.Add(scaleAnimation);

                Storyboard.SetTarget(storyScaleX, slice);

#if NETFX_CORE
                scaleAnimation.EnableDependentAnimation = true;
                Storyboard.SetTargetProperty(storyScaleX, "Height");
#else
                Storyboard.SetTargetProperty(storyScaleX, new PropertyPath("Height"));
#endif
                //EventHandler handler = null;
                //handler = (s, e) =>
                //{
                //    //MessageBox.Show("Completed!");
                //    storyScaleX.Completed -= handler;
                //};
                //storyScaleX.Completed += handler;
                storyScaleX.Begin();
   
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex.ToString ());
            }
        }

        #endregion Methods

        private T FindVisualParentByName<T>(FrameworkElement _Control, string _FindControlName) where T : FrameworkElement
        {
            T t = null;
            DependencyObject obj = VisualTreeHelper.GetParent(_Control); //오브젝트검사            

            for (int i = 0; i < 100; i++) //최대 100개의 컨트롤 까지 검색
            {
                string currentName = obj.GetValue(Control.NameProperty) as string;
                if (currentName == _FindControlName)
                {
                    t = obj as T;
                    break;
                }
                obj = VisualTreeHelper.GetParent(obj); //1번  오브젝트 부모니깐 2번오브젝트 불러오기 계속 이런씩으로 검색 
                if (obj == null) //더이상 검사할 컨트롤 없다 빠져 나가자 ㅡ_ㅡ
                {
                    break;
                }
            }

            return t;

        }

 

    }
}

