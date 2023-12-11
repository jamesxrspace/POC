/* tslint:disable */
/* eslint-disable */
/**
 * Server API - Login
 * The Restful APIs of Login.
 *
 * The version of the OpenAPI document: 1.0.0
 *
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 *
 * @export
 * @interface CreateUploadRequestResponseData
 */
export interface CreateUploadRequestResponseData {
  /**
   * upload request id
   * @type {string}
   * @memberof CreateUploadRequestResponseData
   */
  requestId?: string;
  /**
   * s3 presigned urls for uploading files
   * @type {{ [key: string]: string; }}
   * @memberof CreateUploadRequestResponseData
   */
  presignedUrls?: { [key: string]: string };
}

/**
 * Check if a given object implements the CreateUploadRequestResponseData interface.
 */
export function instanceOfCreateUploadRequestResponseData(value: object): boolean {
  let isInstance = true;

  return isInstance;
}

export function CreateUploadRequestResponseDataFromJSON(
  json: any,
): CreateUploadRequestResponseData {
  return CreateUploadRequestResponseDataFromJSONTyped(json, false);
}

export function CreateUploadRequestResponseDataFromJSONTyped(
  json: any,
  ignoreDiscriminator: boolean,
): CreateUploadRequestResponseData {
  if (json === undefined || json === null) {
    return json;
  }
  return {
    requestId: !exists(json, 'request_id') ? undefined : json['request_id'],
    presignedUrls: !exists(json, 'presigned_urls') ? undefined : json['presigned_urls'],
  };
}

export function CreateUploadRequestResponseDataToJSON(
  value?: CreateUploadRequestResponseData | null,
): any {
  if (value === undefined) {
    return undefined;
  }
  if (value === null) {
    return null;
  }
  return {
    request_id: value.requestId,
    presigned_urls: value.presignedUrls,
  };
}
