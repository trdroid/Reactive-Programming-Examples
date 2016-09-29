# Observers

*Observers* can subscribe to an *Observable* to listen to its events. 
When events occur in an *Observable*, it notifies the subscribed *Observers* by calling relevant methods on them.

An *Observer* can have methods representing the following cases

* *onNext*: which is called by an *Observable* when it emits a new value. 
* *onCompleted*: which is called when there is no more data available. 
* *onError*: which is called when an error occures in the *Observable*.


### Creating Observers

An *Observer* can be created by calling the *create()* method on *Rx.Observer*. 
The *create()* method takes three arguments, all of which are optional

* a function for the *onNext* case
* a function for the *onCompleted* case, which is not necessary when subscribing to an infinite sequence event stream like keyboard hits, mouse clicks
* a function for the *onError* case, which is not necessary when no error conditions are possible at all like when an *Observable* emits a finite sequence of integers or characters

Example:

```javascript
var languagesObserver = Rx.Observer.create(
  function onNext(language) {
    console.log('Langauge:' + language);    
  },
  
  function onError(error) {
    console.log('Error:' + error);    
  },
  
  function onCompleted() {
    console.log('Done!');      
  }
);
```





