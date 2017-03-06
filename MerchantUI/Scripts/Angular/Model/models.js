function merchant() {
    return {
        display_name: 'default name',
        email: '',
        phone: '',
        status: '',
        logo: '',
        address: new address()
    }
}

function address() {
    return {
        address1: '',
        address2: '',
        country: '',
        postcode: '',
        state: '',
        suburb: ''
    };
}