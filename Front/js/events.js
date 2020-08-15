async function add() {
    var someData =
    {
        code: $("#add-code").val(),
        name: $("#add-name").val()
    }

    var url = 'https://localhost:44330/api/home/add'
    const response = await fetch(url, {
        method: 'POST',
        body: JSON.stringify(someData),
        headers: {
            'Content-Type': 'application/json'
        }
    });
    const responseObj = (await response.json());
    if (response.ok) {
        alert('Ok');
    } else {
        console.log(responseObj);
        alert('Validation error');
    }
}

async function update() {
    var someData =
    {
        code: $("#update-code").val(),
        name: $("#update-name").val()
    }

    console.log(someData);
    var id = $("#update-id").val();
    var url = 'https://localhost:44330/api/home/update/' + id;
    if (id == "") alert("Id required");
    const response = await fetch(url, {
        method: 'PUT',
        body: JSON.stringify(someData),
        headers: {
            'Content-Type': 'application/json'
        }
    });
    const responseObj = (await response.json());
    if (response.ok) {
        alert('Ok');
    } else {
        console.log(responseObj);
        alert('Validation error');
    }
}

async function get_all() {
    var url = 'https://localhost:44330/api/home/get-all';
    const response = await fetch(url, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    const responseObj = (await response.json());
    if (response.ok) {
        console.log(responseObj);
        insertData(responseObj);
        alert('Ok');
    } else {
        console.log(responseObj);
        alert('Validation error');
    }
}

function insertData(data) {
    var tbody = $("#table > tbody");
    var content = "";
    data.forEach((item) => {
        content +=
            "<tr>" +
            "<td>" + item.id + "</td>" +
            "<td>" + item.code + "</td>" +
            "<td>" + item.name + "</td>" +
            "</tr>";
    });
    tbody.html(content);
}
