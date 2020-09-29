import com.rabbitmq.client.Channel;
import com.rabbitmq.client.Connection;
import com.rabbitmq.client.ConnectionFactory;

public class CanteenPublisher {
    private final static String QUEUE_NAME = "via_canteen_products_queue";
    public static void main(String[] args) throws  Exception{
        String[] viaProducts = {"Spinach Smoothie", "SoTasty Hawai Pizza"};

        ConnectionFactory factory = new ConnectionFactory();
        factory.setHost("localHost");
        try(Connection conn = factory.newConnection(); Channel channel = conn.createChannel()){
            channel.queueDeclare(QUEUE_NAME, false, false, false, null);

            for (String vp: viaProducts){
                String message = "VIA Canteen's new product: " + vp;
                channel.basicPublish("", QUEUE_NAME, null, message.getBytes());
                System.out.println(" [x] sent '" + message + "'");
            }
        }
    }
}
