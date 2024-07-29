const inputUploader = document.getElementById('uploader');
const filesContainer = document.getElementById('files');
const address = document.getElementById('address');
const fname = document.getElementById("fname");
const lname = document.getElementById("lname");
const adhaar = document.getElementById("adhaar");
const mobile = document.getElementById("mobile");
const dob = document.getElementById("dob");
const registerButton = document.getElementById("registerButton");
const fileNames = document.getElementsByClassName("file");
const statusButton = document.getElementById('status-p-s');
const label = document.querySelector(`label[for="status-p-s"]`);
const reviewDiv = document.getElementById("review");
const regForm = document.getElementById("reg-form");
const reviewButton = document.getElementById("reviewButton");
const keyCheck = document.getElementById("keyCheck");
const keyInput = document.getElementById("keyInput");
const keyCheckButton = document.getElementById("keyCheckButton");

statusButton.addEventListener('click', () => {
    const label = document.querySelector(`label[for="status-p-s"]`);
    if (label.innerText == "Pending")
        label.innerText = "Completed";
    else
        label.innerText = "Pending";
});

registerButton.addEventListener("click", (e) => {

    e.preventDefault();
    const filesSubmitted = [];

    for (let i = 0; i < fileNames.length; i++) {
        filesSubmitted.push(fileNames[i].innerHTML);
    }

    let data = {};
    data.fname = fname.value;
    data.lname = lname.value;
    data.adhaar = adhaar.value;
    data.mobile = mobile.value;
    data.dob = dob.value;
    data.filesSubmitted = filesSubmitted;
    data.status = label.innerText;
    data.address = address.value;
    data.joiningTime = Date.now();

    if (data.fname.length < 2 || data.adhaar.length < 2 || data.address.length < 2 || data.mobile.length < 2) {
        data = {};
        alert("invalid info .");
        return;
    }
    else {
        const key = keyGenerator(data);
        console.log(key);
        data.key = key;
        const template = generateTemplate(data);
        regForm.reset();
        filesContainer.innerHTML="" ;
        reviewButton.classList.toggle('d-none');
        reviewButton.addEventListener('click', (e) => {
          
            keyCheck.classList.toggle('d-none');

            keyCheckButton.addEventListener('click', (e) => {
              
                if (keyInput.value == data.key) {
                    console.log(template);
                    reviewDiv.innerHTML = template;
                }
                else {
                    alert("Invalid key");
                }

            });

        })
        //  
    }

});



















function generateTemplate({ fname, lname, dob, address, mobile, filesSubmitted, status, adhaar, joiningTime }) {

    const template =
        `<p>First name : ${fname}</p>
     <p>Last name : ${lname}</p>
     <p>Mobile no : ${mobile}</p>
     <p>Date of Birth no : ${dob}</p>
     <p>Adhaar no : ${adhaar}</p>
     <p>address :${address}</p>
     <p>Files submitted : <br>${filesSubmitted.join('<br>')}</p>
     <p>Status : ${status}</p>
     <p>joiningTime : ${joiningTime}</p>
     ` ;
    return template;
}
const keyGenerator = (data) => {
    const { fname, adhaar, mobile, address } = data;
    const key = fname.slice(0, 2) + adhaar.slice(0, 2) + address.slice(0, 2) + mobile.slice(0, 2);
    return key;
}
inputUploader.addEventListener('change', (e) => {
    let fileNmae = e.target.files[0].name;
    console.log(fileNmae);
    addFile(fileNmae);
});
const addFile = (fileName) => {
    let div = document.createElement('div');
    div.classList.add('row');
    div.innerHTML = `<p class="col-11 file"> ${fileName}</p>
        <div class="col-1 text-center d-flex align-items-center justify-content-center">
            <i class="fa-solid fa-close " ></i>
        </div>` ;
    filesContainer.appendChild(div);
    const closeButton = div.querySelector('i');
    closeButton.addEventListener('click', () => div.remove())
}



