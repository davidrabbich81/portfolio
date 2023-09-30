import axios from 'axios'

export default {
    getExperiences: () =>
        axios({
            'method':'GET',
            'url':'https://localhost:7214/api/Experience',
            'headers': {
                'content-type':'application/json',
            }
        }),
    getExperience: (id) =>
        axios({
            'method':'GET',
            'url':`https://localhost:7214/api/Experience/${id}`,
            'headers': {
                'content-type':'application/json'
            }
        }),
}