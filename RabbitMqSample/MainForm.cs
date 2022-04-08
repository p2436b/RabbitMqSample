using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Configuration;
using System.Text;

namespace RabbitMqSample
{
  public partial class MainForm : Form
  {
    private IConnection _rabbitMqConnection;
    private IModel _emailChannel;
    private IModel _smsChannel;
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnConnectToRabbitMq_Click(object sender, EventArgs e)
    {
      var connectionString = ConfigurationManager.ConnectionStrings["RabbitMqConnection"].ConnectionString;
      var connectionFactory = new ConnectionFactory();
      connectionFactory.Uri = new Uri(connectionString);
      connectionFactory.AutomaticRecoveryEnabled = true;
      connectionFactory.DispatchConsumersAsync = true;
      try
      {
        _rabbitMqConnection = connectionFactory.CreateConnection("DemoAppClient");
        btnConnectToRabbitMq.BackColor = Color.Green;
      }
      catch
      {
        btnConnectToRabbitMq.BackColor = SystemColors.ButtonFace;
      }

    }

    private void btnCreateExchange_Click(object sender, EventArgs e)
    {
      using var channel = _rabbitMqConnection.CreateModel();
      channel.ExchangeDeclare("CustomerNotification", ExchangeType.Direct, true, false);
    }

    private void btnCreateQueues_Click(object sender, EventArgs e)
    {
      using var channel = _rabbitMqConnection.CreateModel();
      channel.QueueDeclare("Email", true, false, false);
      channel.QueueDeclare("Sms", true, false, false);
    }

    private void btnBindQueues_Click(object sender, EventArgs e)
    {
      using var channel = _rabbitMqConnection.CreateModel();
      channel.QueueBind("Email", "CustomerNotification", "email");
      channel.QueueBind("Sms", "CustomerNotification", "sms");
    }

    private void btnPublishEmail_Click(object sender, EventArgs e)
    {
      using var channel = _rabbitMqConnection.CreateModel();

      var properties = channel.CreateBasicProperties();
      properties.DeliveryMode = 2;

      var message = txtPublishEmail.Text;

      channel.BasicPublish("CustomerNotification", "email", properties, Encoding.UTF8.GetBytes(message));
    }

    private void btnPublishSms_Click(object sender, EventArgs e)
    {
      using var channel = _rabbitMqConnection.CreateModel();

      var properties = channel.CreateBasicProperties();
      properties.DeliveryMode = 2;

      var message = txtPublishSms.Text;

      channel.BasicPublish("CustomerNotification", "sms", properties, Encoding.UTF8.GetBytes(message));
    }

    private void btnSubscribeEmailQueue_Click(object sender, EventArgs e)
    {
      _emailChannel = _rabbitMqConnection.CreateModel();
      _emailChannel.BasicQos(0, 1, false);
      var emailChannelConsumer = new AsyncEventingBasicConsumer(_emailChannel);
      emailChannelConsumer.Received += EmailChannelConsumer_Received;
      _emailChannel.BasicConsume("Email", false, emailChannelConsumer);
    }

    private async Task EmailChannelConsumer_Received(object sender, BasicDeliverEventArgs e)
    {
      var message = Encoding.UTF8.GetString(e.Body.ToArray());
      lstEmailMessages.Invoke((MethodInvoker)(() => lstEmailMessages.Items.Add(message)));
      _emailChannel.BasicAck(e.DeliveryTag, false);
    }

    private void btnSubscribeSmsQueue_Click(object sender, EventArgs e)
    {
      _smsChannel = _rabbitMqConnection.CreateModel();
      _smsChannel.BasicQos(0, 1, false);
      var smsChannelConsumer = new AsyncEventingBasicConsumer(_smsChannel);
      smsChannelConsumer.Received += SmsChannelConsumer_Received;
      _smsChannel.BasicConsume("Sms", false, smsChannelConsumer);
    }

    private async Task SmsChannelConsumer_Received(object sender, BasicDeliverEventArgs e)
    {
      var message = Encoding.UTF8.GetString(e.Body.ToArray());
      lstSmsMessages.Invoke((MethodInvoker)(() => lstSmsMessages.Items.Add(message)));
      _smsChannel.BasicAck(e.DeliveryTag, false);
    }
  }
}