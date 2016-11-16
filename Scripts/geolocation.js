var user_position = { lat: 0, lng: 0 }

function request_distance() {
    if (navigator.geolocation) {
        var timeoutVal = 10 * 1000 * 1000;
        navigator.geolocation.getCurrentPosition(
          set_position,
          set_default({ latitude: 0, longitude: 0 }),
          { enableHighAccuracy: true, timeout: timeoutVal, maximumAge: 0 }
        );
    }
    else {
        set_default({ latitude: 0, longitude: 0 });
    }
    initMap();
}
function set_position(position) {
    user_position.lat = position.latitude;
    user_position.lng = position.longitude;
}
function set_default(position) {
    console.log("Setting Default");
    user_position.lat = position.latitude;
    user_position.lng = position.longitude;
}

$(document).ready(request_distance);