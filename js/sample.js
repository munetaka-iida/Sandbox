foo = function(){console.log('foo!')}

//true && foo() ? console.log('true!') :console.log('false!');

add = function(x) {
  return function(y) {
    return x + ":" + y;
  };
};

console.log(add(1)(2));

//
//var f1 = (value) => {
//    console.log(value);
//    return value
//}
//
//var promise = new Promise(function(resolve, reject) {
//    var isSync = true;
//    if (isSync) {
//        return resolve('Async Hello world');
//    } else {
//        return reject('out!');
//    }
//});
//
//promise
//    .then(f1(2))
//    .then(f1())
//    .then(f1('final'));
