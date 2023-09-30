import config from "../config.json"; 

export default {
    apiUrl: () => {
        return config.apiUrl[process.env.NODE_ENV];
    }
}