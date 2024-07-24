
const selectOptionsGenerator = async (selectId, fileName) => {
    try {
        const response = await fetch(fileName);
        if (!response.ok)
            throw new Error("Network error (not ok)");
        const options = await response.json();
        const selector = document.getElementById(selectId);

        Object.keys(options).forEach((key) => {
            const option = document.createElement('option');
            option.value = key;
            option.textContent = options[key].name;
            selector.appendChild(option);
        });
    } catch (error) {
        console.log(error);
    }
}
selectOptionsGenerator('timePeriod', 'timePeriod.json');
selectOptionsGenerator('currencySelect', 'currancy.json');
selectOptionsGenerator('paymentMethods', 'paymentMethods.json');



const form= document.getElementById("forms") ; 
form.addEventListener("submit",(e)=>{e.preventDefault();}); ;




