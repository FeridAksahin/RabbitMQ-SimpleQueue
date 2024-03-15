using RabbitMQ.Client;
using System.Text;

namespace RabbitMQ_SimpleQueue.Publisher.ProductNotificationPublisher
{
    public class ProductNotificationProducer
    {
        public void PublishProductNotifications()
        {
            try
            {
                var factory = new ConnectionFactory();
                factory.Uri = new Uri("amqps://zvbzklxv:gCbcDnT9UK8-OgT_D4oQkLXr3UpXaZAQ@stingray.rmq.cloudamqp.com/zvbzklxv");
                using var connection = factory.CreateConnection();

                var channel = connection.CreateModel();

                channel.QueueDeclare("product-notification-queue", true, false, false);

                Enumerable.Range(1, 50).ToList().ForEach(x =>
                {
                    var productName = $"test {x}";
                    var price = $"765{x}";

                    var message = $"A new product has been added! Product name: {productName}, Price: {price}.";

                    var byteMessage = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(string.Empty, "product-notification-queue", null, byteMessage);

                    Console.WriteLine("Message has been sent.");
                });
            }
            catch (Exception exception)
            {
                Console.WriteLine("Message has not been sent.");
            }
            Console.ReadLine();
        }
    }
}
