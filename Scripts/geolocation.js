function request_distance() {
    if (navigator.geolocation) {
        var timeoutVal = 10 * 1000 * 1000;
        navigator.geolocation.getCurrentPosition(
          set_position,
          set_default,
          { enableHighAccuracy: true, timeout: timeoutVal, maximumAge: 0 }
        );
    }
    else {
        set_default();
    }
}
function set_position(position) {
    user_position = {
        lat: position.coords.latitude,
        lng: position.coords.longitude
    };
    console.log(user_position);
    initMap(user_position);
}
function set_default(error) {
    var error = {
        1: 'Permission denied',
        2: 'Position unavailable',
        3: 'Request timeout'
    };
    user_position = {
        lat: 0,
        lng: 0
    };
    initMap(user_position);
}

$(document).ready(request_distance);