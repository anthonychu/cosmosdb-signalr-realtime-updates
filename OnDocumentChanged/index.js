module.exports = function (context, documents) {
  context.bindings.signalRMessages =
    documents.map(flight => ({
      target: 'flightUpdated',
      arguments: [ flight ]
    }));
  context.done();
};  