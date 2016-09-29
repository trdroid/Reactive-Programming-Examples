# Observables

### Creating Observables

An *Observable* can be created using the *create()* method on an *Rx.Observable* object. 
The *create()* method accepts a callback which requires an *Observer* instance as an argument.

Example:

```javascript
var languagesObservable = Rx.Observable.create(function(observer) {
  observer.onNext('Scala');
  observer.onNext('Java');
  observer.onNext('Clojure');
  observer.onNext('Swift');
  observer.onCompleted();
});
```
