public abstract class ObjectClass{
	// Abstract visit (accepting consumer)
	void abstract AcceptingConsumer(ObjectClassConsumer consumer);
}

public class ObjectClassV0 : ObjectClass{
	// V0 properties and method
	// Implementing abstract visit (accepting consumer)
	void AcceptingConsumer(ObjectClassConsumer consumer){
		consumer.Consume(this);
	}
}

public class ObjectClassConsumer{
	void Consume(ObjectClassV0){}
}