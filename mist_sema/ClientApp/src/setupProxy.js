const createProxyMiddleware = require('http-proxy-middleware');
const {env} = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
    env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:18218';

const context = [
    "/processors",
    "/system_boards",
    "/storage_devices",
    "/rams",
    "/graphic_cards",
    "/power_supplies",
    "/validate_configuration",
    "/configuration_summary",
    "/add_test_data",
];

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        target: target,
        secure: false
    });

    app.use(appProxy);
};
