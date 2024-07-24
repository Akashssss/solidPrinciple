const amountSelect = document.getElementById("amount");
const currancySelect = document.getElementById("currencySelect");
const roiSelect = document.getElementById("roi");
const timePeriodSelect = document.getElementById("timePeriod");


const EmiCalculate = () => {

    let amount = parseFloat(amountSelect.value);
    const currancy = currancySelect.value;
    const roi = parseFloat(roiSelect.value);
    const timePeriod = timePeriodSelect.value;
    console.log("hello")

    if (isNaN(amount) || isNaN(roi) || amount <= 0 || roi <= 0 || currancy == "" || timePeriod == "") {
        return;
    }
    if (currancy == "d")
        amount = amount * 80;
    else if (currancy == 'b')
        amount = amount * 120;

    let duration;
    switch (timePeriod) {
        case 'y':
            duration = 1;
            break;
        case 'm':
            duration = 12;
            break;
        case 'q':
            duration = 3;
            break;
    }
    let emi;
    const monthlyRate = roi / 12;
    if (monthlyRate === 0) {
        emi = amount / duration;
    } else {
        let x = Math.pow(1 + monthlyRate, duration);
        emi = (amount * x * monthlyRate) / (x - 1);
    }
    console.log(emi);
    const emiBox = document.getElementById('emi');
    emiBox.value = `${emi.toFixed(2)} INR`;
}

amountSelect.addEventListener("input", EmiCalculate);
roiSelect.addEventListener("input", EmiCalculate);
currancySelect.addEventListener("change", EmiCalculate);
timePeriodSelect.addEventListener("change", EmiCalculate);