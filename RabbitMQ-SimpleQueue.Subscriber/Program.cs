using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ_SimpleQueue.Subscriber.ProductNotificationSubscriber;
using System.Text;
using System.Threading.Channels;

namespace RabbitMQ_SimpleQueue.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductNotificationConsumer productNotificationConsumer = new ProductNotificationConsumer();
            productNotificationConsumer.GetProductNotificationMessage();
        }
    }
}
