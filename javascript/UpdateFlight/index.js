module.exports = async function (context, req) {
    const isAuthEnabled = process.env.WEBSITE_AUTH_ENABLED;
    const username = req.headers['x-ms-client-principal-name'];
    if (!isAuthEnabled || !username) {
        context.res = { status: 403, statusText: 'Forbidden' };
        return;
    }

    const flight = req.body;
    flight.username = username;
    context.bindings.flight = flight;
};