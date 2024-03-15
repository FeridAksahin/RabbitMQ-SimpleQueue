using RabbitMQ.Client;
using RabbitMQ_SimpleQueue.Publisher.ProductNotificationPublisher;
using System.Text;

namespace RabbitMQ_SimpleQueue.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductNotificationProducer productNotificationProducer = new ProductNotificationProducer();
            productNotificationProducer.PublishProductNotifications();
        }
    }
}
