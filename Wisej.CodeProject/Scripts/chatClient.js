(function () {

    $(document).ready(function () {

        // Change this with your server url
        //var chatServerUrl = "http://localhost:62154/signalr";
        // Self Hosted SignalR Link
        var chatServerUrl = "http://localhost:8080/signalr";

        var connection = $.hubConnection(chatServerUrl, {
            useDefaultPath: false
        });

        //function connectionStateChanged(state) {
        //    var stateConversion = { 0: 'connecting', 1: 'connected', 2: 'reconnecting', 4: 'disconnected' };
        //    $('#connectionStatus').html('SignalR state changed from: ' + stateConversion[state.oldState]
        //     + ' to: ' + stateConversion[state.newState]);
        //}
        //connection.stateChanged(connectionStateChanged);

        connection.error(function (error) {
            console.log('SignalR error: ' + error)
            if (error.source.type == 'close') {
                $('#connectionStatus').html("DISCONNECTED");
            }
            else if (error.source.readyState === 0) {
                $('#connectionStatus').html("FAILED TO CONNECT");
            }
        });

        // handling slow connections 
        connection.connectionSlow(function () {
            console.log('We are currently experiencing difficulties with the connection.')
        });

        //var chatHubProxy = connection.createHubProxy('messagesHub');
        var chatHubProxy = connection.createHubProxy('signalr');
        // handle the received message from the hub
        chatHubProxy.on('sendMessageToClients', function (message) {
            console.log("Server message: " + message);
            $('#messageHistory').append('<p>' + message + '</p>')
        });

        //connecting the client to the signalr hub   
        connection.start()
            .done(function () {
                $('#connectionStatus').html("CONNECTED");
                console.log("Connected to Signalr Server");
            })
            .fail(function () {
                $('#connectionStatus').html("FAILED TO CONNECT");
                console.log("failed in connecting to the signalr server");
            })

        $("#sendButton").click(function () {
            var alias = $('#alias').val();
            var message = $('#message').val();

            if (!alias) {
                alert('Please enter an alias!');
                return;
            }

            if (!message) {
                alert('Please enter a message!');
                return;
            }

            chatHubProxy.invoke('Send', alias, message).done(function () {
                // clear message
                $('#message').val("");
            }).fail(function (error) {
                console.log('Method Send failed. Error: ' + error);
            });
        });
    });
}());