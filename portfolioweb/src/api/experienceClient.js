import axios from 'axios'
import configService from '../services/configService'

export default {
    getExperiences: () =>
        axios({
            'method':'GET',
            'url':`${configService.apiUrl()}/api/Experience`,
            'headers': {
                'content-type':'application/json',
            }
        }),
    getExperience: (id) =>
        axios({
            'method':'GET',
            'url':`${configService.apiUrl()}/api/Experience/${id}`,
            'headers': {
                'content-type':'application/json'
            }
        }),
}