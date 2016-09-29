# Observers

An *Observer* can subscribe to receive events emitted by an *Observable*. 
An *Observer* is said to consume events of type T emitted by the *Observable\<T\>*

An *Observer* should implement the *Observer\<T\>* interface which is shown below

```java
public interface Observer<T> {
  void onCompleted();
  void onError(Throwable e);
  void onNext(T t);
}
```

**Observer Callbacks**

The *Observer*'s callback methods

* *onCompleted()* is called when the event stream has successfully completed and all events of the stream were successfully delivered.
* *onError(Throwable e)* is called when an error condition occurs which results in the termination of the stream
* *onNext(T t)* is called when a new event is emitted by the observable

```java
public class CustomObserver<T> implements Observer<T> {
  void onCompleted() {
  }
  
  void onError(Throwable e) {
  }
  
  void onNext(T t) {    
  }
}
```

