namespace NancyEmbeddedSharedDependencySample
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;
    using Dependencies;
    using global::Nancy.Hosting.Self;
    using global::Nancy.TinyIoc;
    using Nancy;

    public partial class Form1 : Form
    {
        private readonly TinyIoCContainer appContainer;
        private readonly IUpFrontDependency upFrontDependency;
        private IDelayedDependency delayedDependency;

        public Form1()
        {
            InitializeComponent();

            // Create a new container and register our dependency that we've constructed up front
            appContainer = new TinyIoCContainer();
            upFrontDependency = new UpFrontDependency {Text = InitiallyCreatedTextBox.Text};
            appContainer.Register(upFrontDependency);

            StartNancy();
        }

        private void StartNancy()
        {
            // Create an instance of our own bootstrapper and pass in our pre-configured application container
            var bootstrapper = new BootstrapperWithPassedContainer(appContainer);

            var config = new HostConfiguration
            {
                RewriteLocalhost = false,
                UnhandledExceptionCallback = e => LogBox.Text += string.Format("{0}\n---------\n", e.ToString())
            };

            var host = new NancyHost(bootstrapper, config, new Uri("http://localhost:12345"));
            host.Start();
        }

        private void CreateDependencyButton_Click(object sender, EventArgs e)
        {
            OtherDependencyTextBox.Visible = true;
            CreateDependencyButton.Visible = false;

            // Create our delayed creation dependency and add it to the application container
            delayedDependency = new DelayedDependency {Text = OtherDependencyTextBox.Text};
            appContainer.Register(delayedDependency);
        }

        private void InitiallyCreatedTextBox_TextChanged(object sender, EventArgs e)
        {
            upFrontDependency.Text = InitiallyCreatedTextBox.Text;
        }

        private void OtherDependencyTextBox_TextChanged(object sender, EventArgs e)
        {
            delayedDependency.Text = OtherDependencyTextBox.Text;
        }

        private void LaunchUpFront_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:12345/dependency");
        }

        private void LaunchDelayed_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:12345/delayed");
        }
    }
}