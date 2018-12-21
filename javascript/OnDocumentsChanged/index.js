module.exports = async function (context, updatedFlights) {
  context.bindings.signalRMessages =
    updatedFlights.map(flight => ({
      target: 'flightUpdated',
      arguments: [flight]
    }));
};