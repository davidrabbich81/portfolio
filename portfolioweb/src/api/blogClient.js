import axios from 'axios'
import configService from '../services/configService'

export default {
    getBlogs: () =>
        axios({
            'method':'GET',
            'url':`${configService.apiUrl()}/api/Blog`,
            'headers': {
                'content-type':'application/json',
            }
        }),
    getBlog: (id) =>
        axios({
            'method':'GET',
            'url':`${configService.apiUrl()}/api/Blog/${id}`,
            'headers': {
                'content-type':'application/json'
            }
        }),
}