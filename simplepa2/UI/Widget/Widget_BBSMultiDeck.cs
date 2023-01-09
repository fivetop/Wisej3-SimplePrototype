using simplepa2.UI.Components;
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace simplepa2.UI.Widget
{
    public partial class Widget_BBSMultiDeck : Wisej.Web.UserControl
    {
        private List<Comp_DashBoardBBSDeck> uiList = new List<Comp_DashBoardBBSDeck>();


        public Widget_BBSMultiDeck()
        {
            InitializeComponent();

            setupUI();
        }
        public void setupUI()
        {

            // example
            Comp_DashBoardBBSDeck deck1 = new Comp_DashBoardBBSDeck();
            deck1.Dock = Wisej.Web.DockStyle.Top; 

            Comp_DashBoardBBSDeck deck2 = new Comp_DashBoardBBSDeck();
            deck2.Dock = Wisej.Web.DockStyle.Top;

            Comp_DashBoardBBSDeck deck3 = new Comp_DashBoardBBSDeck();
            deck3.Dock = Wisej.Web.DockStyle.Top;

            Comp_DashBoardBBSDeck deck4 = new Comp_DashBoardBBSDeck();
            deck4.Dock = Wisej.Web.DockStyle.Top;

            Comp_DashBoardBBSDeck deck5 = new Comp_DashBoardBBSDeck();
            deck5.Dock = Wisej.Web.DockStyle.Top;

            this.pn_deckSpace.Controls.Add(deck1);

            this.pn_deckSpace.Controls.Add(newSpacerPanel());            

            this.pn_deckSpace.Controls.Add(deck2);

            this.pn_deckSpace.Controls.Add(newSpacerPanel());

            this.pn_deckSpace.Controls.Add(deck3);

            this.pn_deckSpace.Controls.Add(newSpacerPanel());

            this.pn_deckSpace.Controls.Add(deck4);

            this.pn_deckSpace.Controls.Add(newSpacerPanel());

            this.pn_deckSpace.Controls.Add(deck5);

            this.pn_deckSpace.Controls.Add(newSpacerPanel());





        }

        public Panel newSpacerPanel()
        {
            Panel spacer = new Panel();
            spacer.Dock = Wisej.Web.DockStyle.Top;                        
            spacer.Size = new System.Drawing.Size(720, 12);

            return spacer;
        }

    }
}
