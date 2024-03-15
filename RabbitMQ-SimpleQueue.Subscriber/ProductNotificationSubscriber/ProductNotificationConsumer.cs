using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMQ_SimpleQueue.Subscriber.ProductNotificationSubscriber
{
    public class ProductNotificationConsumer
    {
        public void GetProductNotificationMessage()
        {
            try
            {
                var factory = new ConnectionFactory();
                factory.Uri = new Uri("amqps://zvbzklxv:gCbcDnT9UK8-OgT_D4oQkLXr3UpXaZAQ@stingray.rmq.cloudamqp.com/zvbzklxv");
                var connection = factory.CreateConnection();

                var channel = connection.CreateModel();


                channel.BasicQos(0, 1, false);
                var consumer = new EventingBasicConsumer(channel);

                channel.BasicConsume("product-notification-queue", false, consumer);

                consumer.Received += (sender, e) => Consumer_Received(sender, e, channel);

            }
            catch (Exception exception)
            {
                Console.WriteLine("Message has not been sent.");
            }
            Console.ReadLine();
        }

        private static void Consumer_Received(object? sender, BasicDeliverEventArgs e, IModel channel)
        {
            Console.WriteLine($"Message: {Encoding.UTF8.GetString(e.Body.ToArray())}");

            channel.BasicAck(e.DeliveryTag, false);

        }
    }
}
