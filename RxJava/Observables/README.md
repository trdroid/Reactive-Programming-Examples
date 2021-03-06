# Observables

An *Observable* is an entity that could generate an event stream. 

**Emitting events**

An *Observable* instance could

* **emit** zero or more events in a sequence. These events are of a generic type T which could be emitted by an *Observable* instance at any point in time. An *Observable* can emit
    * a single scalar value (or)
    * a sequence of values (or)
    * a stream that could generate infinite values
* **emit** a *Throwable* if failures occur during event processing

**Observer subscription**

The *Observers* can subscribe to the event stream generated by an *Observable*. An *Observable*

* provides methods for *Observers* to subscribe to it
* manages *Observer* subscriptions

### Observable vs Iterable

An *Observable* follows an asynchronous or a push approach whereas an *Iterable* follows a synchronous or a pull approach.

| Observable        | Iterable           | Description  |
| ------------- |:-------------:|:-----|
| onNext(T)      | T next() | method to notify/retrieve the data |
| onError(Throwable e)      | throws Exception      |   method to notify/throw an exception |
| onCompleted() | !hasNext()      |  method to notify/query about completion  |

## Types of Observables

### Hot vs Cold Observables

An *observable* is either a *hot observable* or a *cold observable* depending on when it starts emitting events. 

**Hot Observables**

A *hot observable* is an observable that begins emitting events the moment it gets created. 
An *Observer* subscribed to a *hot observable* receives events ONLY after the subscription; 
all the events emitted prior to the subscription are not received by the *observer*. 

**Cold Observables**

A *cold observable* is an observable that begins emitting events ONLY when an *observer* subscribes to it, 
in which case the subscribed *observer* receives all events from the event stream.

### Single

A *Single* is an *observable* that can emit ONLY

* a single event value on success (or)
* an error event on failure




