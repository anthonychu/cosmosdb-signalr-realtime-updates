module.exports = function (context, req, flights) {
  context.res.body = flights;
  context.done();
};