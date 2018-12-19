module.exports = async function (context, req) {
    context.bindings.flight = req.body;
};