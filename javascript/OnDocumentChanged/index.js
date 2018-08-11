module.exports = function (context, documents) {
  const flightUpdates = documents.map(flight => ({
    target: 'flightUpdated',
    arguments: [ flight ]
  }));
  context.bindings.signalRMessages = flightUpdates
  context.done();
};  