// window.open("Contact.html", "_blank", "toolbar=yes,scrollbars=yes,resizable=yes,top=500,left=500,width=400,height=400");
// alert("Hi");
const fname = document.getElementById("name");
const email = document.getElementById("email");
const dob = document.getElementById("dob");
const interest = document.getElementById("interest");
const individual = document.getElementById("individual");
const organization = document.getElementById("organization");
const about = document.getElementById("about");
const errorElement = document.getElementById("username");
const form = document.getElementById("form");

// Preventing from submitting bofore error identification

form.addEventListener("submit", (e) => {

    let messages = [];
    if (fname.value === "" || fname.value == null) {
        // messages.push("Name is required");
        document.getElementById("username").innerHTML="  *** Please fill the username"
    }
    if (fname.value.length < 5) {
        messages.push("Name is too short");
    }
    if (fname.value.length > 20) {
        messages.push("Name is too long");
    }
    if (email.value === "" || email.value == null) {
        // messages.push("email is required");
        document.getElementById("emailid").innerHTML="  *** Please fill the email"

    }
    if (!(dob.value)) {
        document.getElementById("dobs").innerHTML="  *** Select the date"
    }
    // if(!organization.checked || !individual.checked) {
    //     document.getElementById("organizations").innerHTML="  *** Select the individual"
    //     document.getElementById("individuals").innerHTML="  *** Select the individual"
      
    // }
    
    if (about.value.length ==0) {
        document.getElementById("aboutus").innerHTML="  *** We really need to know about yourself"
        // messages.push("We really need to know about yourself");
    }
  
    if (messages.length > 0) {
        e.preventDefault();
        errorElement.innerText = messages.join(',');
    }
})

let url = window.location.search;
let queries = new URLSearchParams(url);
let name1 = queries.get("name");
let email1 = queries.get("email");
let dob1 = queries.get("dob");
let interest1 = queries.get("interest");
let about1 = queries.get("about");
let organization1=queries.get("organization");
let individual1=queries.get("individual");
let A= [name1,email1,dob1,interest1,organization1,individual1,about1];
openWindow = window.open("Contact.html", "_blank", "toolbar=yes,scrollbars=yes,resizable=yes,top=500,left=500,width=400,height=400");
for (i=0; i<1;i++) {
    openWindow.document.write( A +'   '+'\n');
}

// new




// Next Method
// function ValidateInput() {
// 	const fname = document.getElementById("name");
// 	var txtUser = document.getElementById("txtUser");
// 	try {
// 		if (x == "") throw "empty";
// 	}
// 	catch (err) {
// 		divJs.innerHTML = "Input is " + err;
// 	}

// }



































// function setError(id,error) {
//     element = document.getElementById('id');
//     element.getElementsbyClassName('formerror')[0].innerHTML = error;
// }


// function validateForm() {
//     var name = document.forms['myForm']['name'].value;
//     console.log(name);
//     if (name.lenght<6) {
//         // setError("name","The Lenght of namr is too short")
//         alert('The lenght of name is too short');
//         return false;
//     }
//     return false;
// }