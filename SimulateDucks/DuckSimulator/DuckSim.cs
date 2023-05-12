using DuckBehaviour;
namespace DuckSimulator
{
    public partial class DuckSim : Form
    {
        private Duck _sim;
        public DuckSim()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblDuckData.Text = _sim.Display();
        }

        private void btnFly_Click(object sender, EventArgs e)
        {
            lblDuckData.Text = _sim.performFly();
        }

        private void btnQuack_Click(object sender, EventArgs e)
        {
            lblDuckData.Text = _sim.performQuack();
        }

        private void rdbMallard_CheckedChanged(object sender, EventArgs e)
        {
            _sim = new MallardDuck();
        }

        private void rdbRedhead_CheckedChanged(object sender, EventArgs e)
        {
            _sim = new RedheadDuck();
        }

        private void rdbRubber_CheckedChanged(object sender, EventArgs e)
        {
            _sim = new RubberDuck();
        }

        private void rdbDecoy_CheckedChanged(object sender, EventArgs e)
        {
            _sim = new DecoyDuck();
        }
    }
}