import dateDiff from "../functions/dateDiff";

export default { 
    fullName: "David Rabbich",
    firstName: "David",
    lastName: "Rabbich",
    phoneNumber: "+44 7793 238893",
    from: "Morecambe, England",
    emailAddress: "david@rabbich.dev",
    age: () => {  
        const now = new Date();
        const dob = new Date("1981-05-11") 
        return dateDiff(dob, now);
    },
    yearsExperience: () => {
        const now = new Date();
        const dob = new Date("1998-10-04") 
        return dateDiff(dob, now);
    }
 };