module.exports = async function (context, req, flights) {
  context.res.body = flights;
};